/////////////////////////////////////////////////////////////////////////////
//
// Microsoft.CodeAnalysis.ActivePatterns - F# Active pattern matching library for Roslyn
// Copyright (c) Kouji Matsui (@kozy_kekyo, @kekyo@mastodon.cloud)
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

namespace Microsoft.CodeAnalysis.Loose

open Microsoft.CodeAnalysis
open Microsoft.CodeAnalysis.CSharp

[<AutoOpen>]
module Additionals =

  let (|Token|_|) (node:SyntaxToken) : string option =
    Some node.Text

  let (|Identifier|_|) node : string list option =
    let rec matcher (node:SyntaxNode) =
        match node with
        | IdentifierName(Token(text)) ->
            Some [ text ]
        | QualifiedName(left, _, right) ->
            matcher left |> Option.bind(fun left -> matcher right |> Option.bind(fun right -> Some (List.append left right)))
        | _ ->
            None
    matcher node
