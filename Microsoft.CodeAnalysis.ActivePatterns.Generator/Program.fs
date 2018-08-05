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
open System.Diagnostics

////////////////////////////////////////////

let objType = typeof<obj>
let seqType = typedefof<seq<_>>

let baseNodeType = typeof<Microsoft.CodeAnalysis.SyntaxNode>
let csharpNodeType = typeof<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>
let visualBasicNodeType = typeof<Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode>

let syntaxListType = typedefof<Microsoft.CodeAnalysis.SyntaxList<_>>
let syntaxTokenType = typeof<Microsoft.CodeAnalysis.SyntaxToken>

////////////////////////////////////////////

let getSyntaxListElementType (t:Type) =
    if t.IsGenericType && (t.GetGenericTypeDefinition() = syntaxListType) then
        Some (t.GetGenericArguments().[0])
    else
        None

let (|Value|Token|Node|List|Another|) (t:Type) =
    if t.IsPrimitive || t.IsEnum || t = typeof<string> then
        Value t
    else if syntaxTokenType.IsAssignableFrom t then
        Token t
    else if baseNodeType.IsAssignableFrom t then
        Node t
    else
        match getSyntaxListElementType t with
        | Some et -> List et
        | _ -> Another

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
    
let getTupleArgs (t: Type) =
      t.GetProperties(BindingFlags.Public ||| BindingFlags.Instance ||| BindingFlags.DeclaredOnly)
      |> Seq.choose targetProperty
      |> Seq.toArray

let getTupleArgsString (name: string) (p: PropertyInfo) =
    match p.PropertyType with
    | Value et
    | Token et
    | Node et ->
        Some (String.Format("{0}.{1}", name, p.Name))
    | List et ->
        Some (String.Format("{0}.{1} |> Seq.toList", name, p.Name))
    | Another ->
        None

let getTupleArgsStringWithCast (name: string) (p: PropertyInfo) (ct: Type) =
    match p.PropertyType with
    | Value et
    | Token et
    | Node et ->
        if p.PropertyType <> ct then
            Some (String.Format("{0}.{1} :> {2}", name, p.Name, ct.FullName))
        else
            Some (String.Format("{0}.{1}", name, p.Name))
    | List et ->
        if p.PropertyType <> ct then
            if ct.IsGenericType && ct.GetGenericTypeDefinition() = seqType then
                let gt = ct.GetGenericArguments().[0]
                Some (String.Format("{0}.{1} |> Seq.cast<{2}> |> Seq.toList", name, p.Name, gt.FullName))
            else
                Some (String.Format("{0}.{1} :> {2}", name, p.Name, ct.FullName))
        else
            Some (String.Format("{0}.{1} |> Seq.toList", name, p.Name))
    | Another ->
        None

let getPatternName (t: Type) =
    let name = t.Name
    if name.EndsWith "Syntax" then
        name.Substring(0, name.Length - 6)
    else
        name

////////////////////////////////////////////

let writeHeader (tw: TextWriter) =
    tw.WriteLine("// This is auto-generated source code by Microsoft.CodeAnalysis.ActivePatterns, DO NOT EDIT!")
    tw.WriteLine()
       
let generateActivePatternsForValue path (namespaceName: string) (valueTypes: Type seq) (nodeName: Type -> string) =
    use tw = File.CreateText(path)

    writeHeader tw

    tw.WriteLine("namespace {0}", namespaceName)
    tw.WriteLine()
    tw.WriteLine("[<AutoOpen>]")
    tw.WriteLine("module ActivePatterns =")
    tw.WriteLine()

    valueTypes |> Seq.iter (fun t ->
        let tupleArgs =
            getTupleArgs t
            |> Seq.choose (getTupleArgsString "value")
            |> Seq.toArray
        if not (Array.isEmpty tupleArgs) then
            tw.WriteLine(
                "  let (|{0}|) (value:{1}) =",
                t.Name,
                nodeName t)
            tw.WriteLine("    {0} ({1})", t.Name, String.Join(", ", tupleArgs))
            tw.WriteLine())

    tw.Flush()

////////////////////////////////////////////

let rec detectCommonType t1 t2 =
    // t1:  Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
    // t2:  Microsoft.CodeAnalysis.VisualBasic.Syntax.QualifiedNameSyntax
    // ans: Microsoft.CodeAnalysis.SyntaxNode

    match getSyntaxListElementType t1, getSyntaxListElementType t2 with
    | Some(et1), Some(et2) ->
        seqType.MakeGenericType([| detectCommonType et1 et2 |])
    | _ ->
        let rec derivedTypeList (t: Type) (tl: Type list): Type list =
            if t = objType then t :: tl
            else derivedTypeList t.BaseType (t :: tl)
        let t1List = derivedTypeList t1 []
        let t2List = derivedTypeList t2 []
        Seq.zip t1List t2List |> Seq.filter (fun (t1, t2) -> t1 = t2) |> Seq.toArray |> Seq.last |> fst

let generateLooseActivePatternsForSyntax path (namespaceName: string) (syntaxTypes: Type seq) (nodeName: Type -> string) =
    use tw = File.CreateText(path)

    writeHeader tw

    tw.WriteLine("namespace {0}", namespaceName)
    tw.WriteLine()
    tw.WriteLine("[<AutoOpen>]")
    tw.WriteLine("module ActivePatterns =")
    tw.WriteLine()

    syntaxTypes
    // Combined by active pattern name (both C# and VB)
    |> Seq.groupBy getPatternName
    |> Seq.iter (fun (patternName, types) ->
        let argPropertiesByTypesList =
            types
            |> Seq.map (fun t -> t, getTupleArgs t)
            |> Seq.filter (fun (_, ps) ->
                // Cannot deconstruct nothing properties
                (not (Array.isEmpty ps))
                // Cannot deconstruct contains unknown property types
                && (not (ps |> Seq.exists(fun p -> match p.PropertyType with Another -> true | _ -> false))))
            |> Seq.toArray
        // 0 ~ [C#; VB]
        Debug.Assert(argPropertiesByTypesList.Length <= 2)

        let emitOnlyOne (typesList: (Type * PropertyInfo[])[]) =
            // Generate argument expressions
            let argStringsByTypesList =
                typesList
                |> Seq.map (fun (t, ps) -> t, ps |> Seq.choose (getTupleArgsString "node") |> Seq.toArray)
                |> Seq.toArray

            tw.WriteLine(
                "  let (|{0}|_|) (node:{1}) =",
                patternName,
                nodeName baseNodeType)
            tw.WriteLine("    match node with")

            let t, tupleArgs = argStringsByTypesList.[0]
            tw.WriteLine("    | :? {0} as node ->", t.FullName)
            tw.WriteLine("      Some ({0})", String.Join(", ", tupleArgs))
            tw.WriteLine("    | _ -> None")
            tw.WriteLine()

        let emitBothPatterns (typesList: (Type * PropertyInfo[])[]) =
            // Generate argument expressions
            let argStringsByTypesList =
                typesList
                |> Seq.map (fun (t, ps) -> t, ps |> Seq.choose (getTupleArgsString "node") |> Seq.toArray)
                |> Seq.toArray

            argStringsByTypesList |> Seq.iter(fun (t, tupleArgs) ->
                tw.WriteLine(
                    "  let (|{0}{1}|_|) (node:{2}) =",
                    t.FullName.Split(".").[2],      // HACK: Index 2 is language name (CSharp, VisualBasic)
                    patternName,
                    nodeName baseNodeType)
                tw.WriteLine("    match node with")
                tw.WriteLine("    | :? {0} as node ->", t.FullName)
                tw.WriteLine("      Some ({0})", String.Join(", ", tupleArgs))
                tw.WriteLine("    | _ -> None")
                tw.WriteLine())

        let emitByCast (typesList: (Type * PropertyInfo[])[]) argCommonTypes =
            // Generate argument expressions
            let argStringsByTypesList =
                argPropertiesByTypesList
                |> Seq.map (fun (t, ps) ->
                    t,
                    Seq.zip ps argCommonTypes |> Seq.choose (fun (p, ct) -> getTupleArgsStringWithCast "node" p ct) |> Seq.toArray)
                |> Seq.toArray

            tw.WriteLine(
                "  let (|{0}|_|) (node:{1}) =",
                patternName,
                nodeName baseNodeType)
            tw.WriteLine("    match node with")

            argStringsByTypesList |> Seq.iter(fun (t, tupleArgs) ->
                tw.WriteLine("    | :? {0} as node ->", t.FullName)
                tw.WriteLine("      Some ({0})", String.Join(", ", tupleArgs)))

            tw.WriteLine("    | _ -> None")
            tw.WriteLine()

        match argPropertiesByTypesList.Length, argPropertiesByTypesList |> Seq.distinctBy (fun (_, ps) -> ps.Length) |> Seq.length with
        // C# only or VB only
        | 1, _ -> emitOnlyOne argPropertiesByTypesList
        // both C# and VB (argument count is differ)
        | 2, 2 -> emitBothPatterns argPropertiesByTypesList
        // both C# and VB (argument count is equals)
        | 2, 1 ->
            // Calculate common types
            let argCommonTypes =
                Seq.zip (argPropertiesByTypesList.[0] |> snd) (argPropertiesByTypesList.[1] |> snd)
                |> Seq.map (fun (ps1, ps2) -> detectCommonType ps1.PropertyType ps2.PropertyType)
                |> Seq.toArray

            let isCastable (t: Type) =
                (baseNodeType.IsAssignableFrom t)
                || (syntaxTokenType.IsAssignableFrom t)
                || t.IsInterface

            match argCommonTypes |> Seq.exists (isCastable >> not) with
            // Argument contains not castable.
            | true -> emitBothPatterns argPropertiesByTypesList
            // All arguments castable.
            | false -> emitByCast argPropertiesByTypesList argCommonTypes
    
        | _ ->
            ())

    tw.Flush()

////////////////////////////////////////////

let generateStrictActivePatternsForSyntax path (namespaceName: string) (syntaxTypes: Type seq) (nodeName: Type -> string) =
    use tw = File.CreateText(path)

    writeHeader tw

    tw.WriteLine("namespace {0}", namespaceName)
    tw.WriteLine()
    tw.WriteLine("[<AutoOpen>]")
    tw.WriteLine("module ActivePatterns =")
    tw.WriteLine()

    syntaxTypes |> Seq.iter (fun t ->
        let tupleArgs =
            getTupleArgs t
            |> Seq.choose (getTupleArgsString "node")
            |> Seq.toArray
        if not (Array.isEmpty tupleArgs) then
            tw.WriteLine(
                "  let (|{0}|_|) (node:{1}) =",
                getPatternName t,
                nodeName t)
            tw.WriteLine("    match node with")
            tw.WriteLine("    | :? {0} as node ->", t.FullName)
            tw.WriteLine("      Some ({0})", String.Join(", ", tupleArgs))
            tw.WriteLine("    | _ -> None")
            tw.WriteLine())

    tw.Flush()

////////////////////////////////////////////

let getTargetPath (prefix: string) fileName =
    if prefix.Length >= 1 then
        (Path.Combine("..","..","..","..", "Microsoft.CodeAnalysis.ActivePatterns", prefix, fileName))
    else
        (Path.Combine("..","..","..","..", "Microsoft.CodeAnalysis.ActivePatterns", fileName))

let rec baseAbstractType (bottomType: Type) (t: Type) =
    if t = bottomType then
        t
    else
        let baseType = t.BaseType
        if not baseType.IsAbstract && t.IsAbstract then
            t
        else
            baseAbstractType bottomType baseType
    
let getNodeName bottomType t =
    (baseAbstractType bottomType t).FullName
        
////////////////////////////////////////////

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

    generateActivePatternsForValue
        (getTargetPath "" "ActivePatterns.fs")
        "Microsoft.CodeAnalysis"
        (valueTypes baseNodeType)
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

    generateLooseActivePatternsForSyntax
        (getTargetPath "Loose" "ActivePatterns.fs")
        (baseNodeType.Namespace + ".Loose")
        (Seq.append (syntaxTypes csharpNodeType) (syntaxTypes visualBasicNodeType))
        (getNodeName baseNodeType)

    generateStrictActivePatternsForSyntax
        (getTargetPath "Strict" "CSharpActivePatterns.fs")
        (csharpNodeType.Namespace + ".Strict")
        (syntaxTypes csharpNodeType)
        (getNodeName csharpNodeType)
    generateStrictActivePatternsForSyntax
        (getTargetPath "Strict" "VisualBasicActivePatterns.fs")
        (visualBasicNodeType.Namespace + ".Strict")
        (syntaxTypes visualBasicNodeType)
        (getNodeName visualBasicNodeType)

    0
