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

// This code sample is using for this library.

// It goals to clarify why we want to active pattern library.
// You can compare the "csharp_standard_usage_sample" project (contains C# version).

module test

open System
open System.IO
open System.Reflection
open System.Text

open Microsoft.CodeAnalysis
open Microsoft.CodeAnalysis.CSharp

// This is a namespace for active pattern functions.
// "Strict" means strongly typed args and return types.
open Microsoft.CodeAnalysis.CSharp.Strict

// You can use "Loose" namespace if you are requiring loose traverser by base AST node types.
// (ex: Microsoft.CodeAnalysis.SyntaxNode)
// Loose pattern functions NOT lesser than Strict.
// Because it can make unified traverser for C# and VB AST nodes.

[<EntryPoint>]
let main argv =
    let sampleCode =
        use fs = Assembly.GetEntryAssembly().GetManifestResourceStream "test.Sample.cs"
        let tr = new StreamReader(fs, Encoding.UTF8)
        tr.ReadToEnd()

    let tree = CSharpSyntaxTree.ParseText sampleCode :?> CSharpSyntaxTree
    let root = tree.GetRoot()
        
    // Roslyn C# AST can handle by F#'s pattern matching.
    // AST types deconstructs by this library's active pattern functions.
    // And syntax node pattern naming is shorter.

    match root with
    | CompilationUnit
       (_, [ UsingDirective(_, _, _, _, Identifier(["System";"Collections";"Generic"]), _)], _,
         [ NamespaceDeclaration(_, Token("SampleNamespace"), _, _, _,
            [ ClassDeclaration(decl,
                _, Token("SampleClass"), _, _, _, _,
                memberDecls,
                _, _)],
            _, _, _) ],
         _) ->
            memberDecls
            |> Seq.choose (function
              | PropertyDeclaration(_, typeSyntax, _, Token(id), _, _, _, _) ->
                 Some (typeSyntax, id)
              | _ -> None)
            |> Seq.iter (printf "%A")
            
    | _ -> ()
    0

