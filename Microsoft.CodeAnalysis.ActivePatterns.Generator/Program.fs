/////////////////////////////////////////////////////////////////////////////
//
// Microsoft.CodeAnalysis.ActivePatterns - F# Active pattern matching library for Roslyn
// Copyright (c) 2016 Kouji Matsui (@kekyo2)
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
/////////////////////////////////////////////////////////////////////////////

open System
open System.IO
open System.Reflection

let obsoleteType = typeof<ObsoleteAttribute>
let isObsoleted (m:MemberInfo) =
    if m.IsDefined obsoleteType then
        true
    else
        false

let rec baseAbstractType (t: Type) =
    let baseType = t.BaseType
    if not baseType.IsAbstract && t.IsAbstract then
        t
    else
        baseAbstractType baseType

let generateActivePatterns path (namespaceName: string) (syntaxTypes: Type seq) (nodeName: Type -> string) =
    use tw = File.CreateText(path)

    tw.WriteLine("namespace {0}", namespaceName)
    tw.WriteLine()
    tw.WriteLine("[<AutoOpen>]")
    tw.WriteLine("module ActivePatterns =")
    tw.WriteLine()

    let syntaxListType =
        typedefof<Microsoft.CodeAnalysis.SyntaxList<_>>
    let syntaxNodeType = typeof<Microsoft.CodeAnalysis.SyntaxNode>
    let syntaxTokenType = typeof<Microsoft.CodeAnalysis.SyntaxToken>
    let (|NodeType|SyntaxList|Another|) (t:Type) =
        if t.IsPrimitive || t.IsEnum || t = typeof<string> then
            NodeType t
        else if syntaxNodeType.IsAssignableFrom t then
            NodeType t
        else if syntaxTokenType.IsAssignableFrom t then
            NodeType t
        else if t.IsGenericType && (t.GetGenericTypeDefinition() = syntaxListType) then
            SyntaxList (t.GetGenericArguments().[0])
        else
            Another
    let (|NotVisible|_|) (m: MethodBase) =
        if (m = null) || not m.IsPublic || m.IsStatic then Some m else None
    let targetProperty (p: PropertyInfo) =
        match p.CanRead, p.GetIndexParameters().Length >= 1, p.GetGetMethod(), isObsoleted p, p.PropertyType with
        | false, _, _, _, _ -> None
        | _, true, _, _, _ -> None
        | _, _, NotVisible _, _, _ -> None
        | _, _, _, true, _ -> None
        | _, _, _, _, NodeType et
        | _, _, _, _, SyntaxList et -> Some p
        | _ -> None

    syntaxTypes |> Seq.iter (fun t ->
        tw.WriteLine(
            "  let (|{0}|_|) (node:{1}) =",
            t.Name,
            nodeName t)
        tw.WriteLine("    match node with")
        tw.WriteLine("    | :? {0} as node ->", t.FullName)
        let props =
            t.GetProperties(BindingFlags.Public ||| BindingFlags.Instance ||| BindingFlags.DeclaredOnly)
            |> Seq.choose targetProperty
            |> Seq.toArray
        let tupleArgs =
            props
            |> Seq.choose (fun p ->
                match p.PropertyType with
                | NodeType et ->
                    Some (String.Format("node.{0}", p.Name))
                | SyntaxList et ->
                    Some (String.Format("node.{0} |> Seq.toList", p.Name))
                | Another ->
                    None)
            |> Seq.toArray
        tw.WriteLine("      Some ({0})", String.Join(", ", tupleArgs))
        tw.WriteLine("    | _ -> None")
        tw.WriteLine())

    tw.Flush()

[<EntryPoint>]
let main argv =
    let syntaxTypes (nodeType: Type) =
        nodeType.Assembly.GetTypes()
        |> Seq.filter (fun t ->
            t.IsPublic &&
            t.IsValueType &&
            (not t.IsGenericType) &&
            (not (isObsoleted t)))
        |> Seq.toArray

    let nodeType = typeof<Microsoft.CodeAnalysis.SyntaxNode>
            
    generateActivePatterns
        @"..\..\..\Microsoft.CodeAnalysis.ActivePatterns\ActivePatterns.fs"
        "Microsoft.CodeAnalysis"
        (syntaxTypes nodeType)
        (fun t -> t.FullName)

    let syntaxTypes (nodeType: Type) =
        nodeType.Assembly.GetTypes()
        |> Seq.filter (fun t ->
            t.IsPublic &&
            t.IsSealed &&
            (not t.IsGenericType) &&
            nodeType.IsAssignableFrom t &&
            (not (isObsoleted t)))
        |> Seq.toArray

    let csharpNodeType = typeof<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>
    generateActivePatterns
        @"..\..\..\Microsoft.CodeAnalysis.ActivePatterns\CSharpActivePatterns.fs"
        csharpNodeType.Namespace
        (syntaxTypes csharpNodeType)
        (fun t -> (baseAbstractType t).FullName)

    let visualBasicNodeType = typeof<Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode>
    generateActivePatterns
        @"..\..\..\Microsoft.CodeAnalysis.ActivePatterns\VisualBasicActivePatterns.fs"
        visualBasicNodeType.Namespace
        (syntaxTypes visualBasicNodeType)
        (fun t -> (baseAbstractType t).FullName)

    0
