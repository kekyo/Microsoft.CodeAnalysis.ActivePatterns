/////////////////////////////////////////////////////////////////////////////
//
// Microsoft.CodeAnalysis.ActivePatterns - F# Active pattern matching library for Roslyn
// Copyright (c) 2016-2018 Kouji Matsui (@kozy_kekyo)
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

module Generator

open System
open System.IO
open System.Reflection

let syntaxListType =
    typedefof<Microsoft.CodeAnalysis.SyntaxList<_>>
let syntaxNodeType = typeof<Microsoft.CodeAnalysis.SyntaxNode>
let syntaxTokenType = typeof<Microsoft.CodeAnalysis.SyntaxToken>

let (|Value|Token|Node|List|Another|) (t:Type) =
    if t.IsPrimitive || t.IsEnum || t = typeof<string> then
        Value t
    else if syntaxTokenType.IsAssignableFrom t then
        Token t
    else if syntaxNodeType.IsAssignableFrom t then
        Node t
    else if t.IsGenericType && (t.GetGenericTypeDefinition() = syntaxListType) then
        List (t.GetGenericArguments().[0])
    else
        Another
let (|NotVisible|_|) (m: MethodBase) =
    if (m = null) || not m.IsPublic || m.IsStatic then Some m else None

let obsoleteType = typeof<ObsoleteAttribute>
let isObsoleted (m:MemberInfo) =
    if m.IsDefined obsoleteType then
        true
    else
        false

let targetProperty (p: PropertyInfo) =
    match p.CanRead, p.GetIndexParameters().Length >= 1, p.GetGetMethod(), isObsoleted p, p.PropertyType with
    | false, _, _, _, _ -> None
    | _, true, _, _, _ -> None
    | _, _, NotVisible _, _, _ -> None
    | _, _, _, true, _ -> None
    | _, _, _, _, Value et
    | _, _, _, _, Token et
    | _, _, _, _, Node et
    | _, _, _, _, List et -> Some p
    | _ -> None
let getTupleArgs (t: Type) (name: string) =
      t.GetProperties(BindingFlags.Public ||| BindingFlags.Instance ||| BindingFlags.DeclaredOnly)
      |> Seq.choose targetProperty
      |> Seq.toArray
      |> Seq.choose (fun p ->
          match p.PropertyType with
          | Value et
          | Token et
          | Node et ->
              Some (String.Format("{0}.{1}", name, p.Name))
          | List et ->
              Some (String.Format("{0}.{1} |> Seq.toList", name, p.Name))
          | Another ->
              None)
      |> Seq.toArray

let generateActivePatternsForValue path (namespaceName: string) (valueTypes: Type seq) (nodeName: Type -> string) =
    use tw = File.CreateText(path)

    tw.WriteLine("namespace {0}", namespaceName)
    tw.WriteLine()
    tw.WriteLine("[<AutoOpen>]")
    tw.WriteLine("module ActivePatterns =")
    tw.WriteLine()

    valueTypes |> Seq.iter (fun t ->
        let tupleArgs = getTupleArgs t "value"
        if not (Array.isEmpty tupleArgs) then
            tw.WriteLine(
                "  let (|{0}|) (value:{1}) =",
                t.Name,
                nodeName t)
            tw.WriteLine("    {0} ({1})", t.Name, String.Join(", ", tupleArgs))
            tw.WriteLine())

    tw.Flush()

let generateActivePatternsForSyntax path (namespaceName: string) (moduleName: string) (syntaxTypes: Type seq) (nodeName: Type -> string) =
    use tw = File.CreateText(path)

    tw.WriteLine("namespace {0}", namespaceName)
    tw.WriteLine()
    tw.WriteLine("[<AutoOpen>]")
    tw.WriteLine("module {0} =", moduleName)
    tw.WriteLine()

    syntaxTypes |> Seq.iter (fun t ->
        let tupleArgs = getTupleArgs t "node"
        if not (Array.isEmpty tupleArgs) then
            tw.WriteLine(
                "  let (|{0}|_|) (node:{1}) =",
                t.Name,
                nodeName t)
            tw.WriteLine("    match node with")
            tw.WriteLine("    | :? {0} as node ->", t.FullName)
            tw.WriteLine("      Some ({0})", String.Join(", ", tupleArgs))
            tw.WriteLine("    | _ -> None")
            tw.WriteLine())

    tw.Flush()

let getTargetPath (prefix: string) fileName =
    if prefix.Length >= 1 then
        (Path.Combine("..","..","..","..", "Microsoft.CodeAnalysis.ActivePatterns", prefix, fileName))
    else
        (Path.Combine("..","..","..","..", "Microsoft.CodeAnalysis.ActivePatterns", fileName))

[<EntryPoint>]
let main argv =
    let valueTypes (nodeType: Type) =
        nodeType.Assembly.GetTypes()
        |> Seq.filter (fun t ->
            t.IsPublic &&
            t.IsValueType &&
            (not t.IsEnum) &&
            (not t.IsGenericType) &&
            (not (isObsoleted t)))
        |> Seq.toArray

    let nodeType = typeof<Microsoft.CodeAnalysis.SyntaxNode>
            
    generateActivePatternsForValue
        (getTargetPath "" "ActivePatterns.fs")
        "Microsoft.CodeAnalysis"
        (valueTypes nodeType)
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

    let rec baseAbstractType (bottomType: Type) (t: Type) =
        if t = bottomType then
            t
        else
            let baseType = t.BaseType
            if not baseType.IsAbstract && t.IsAbstract then
                t
            else
                baseAbstractType bottomType baseType
    let objType = typeof<obj>

    let csharpNodeType = typeof<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>
    generateActivePatternsForSyntax
        (getTargetPath "Raw" "CSharpActivePatterns.fs")
        (csharpNodeType.Namespace + ".Raw")
        "CSharpActivePatterns"
        (syntaxTypes csharpNodeType)
        (fun t -> (baseAbstractType objType t).FullName)
    generateActivePatternsForSyntax
        (getTargetPath "" "CSharpActivePatterns.fs")
        csharpNodeType.Namespace
        "CSharpActivePatterns"
        (syntaxTypes csharpNodeType)
        (fun t -> (baseAbstractType csharpNodeType t).FullName)

    let visualBasicNodeType = typeof<Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode>
    generateActivePatternsForSyntax
        (getTargetPath "Raw" "VisualBasicActivePatterns.fs")
        (visualBasicNodeType.Namespace + ".Raw")
        "VisualBasicActivePatterns"
        (syntaxTypes visualBasicNodeType)
        (fun t -> (baseAbstractType objType t).FullName)
    generateActivePatternsForSyntax
        (getTargetPath "" "VisualBasicActivePatterns.fs")
        visualBasicNodeType.Namespace
        "VisualBasicActivePatterns"
        (syntaxTypes visualBasicNodeType)
        (fun t -> (baseAbstractType visualBasicNodeType t).FullName)

    0
