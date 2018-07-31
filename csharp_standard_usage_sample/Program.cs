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

// This code sample is standard usages for roslyn C# parser.
// It's part of Microsoft.CodeAnalysis.ActivePatterns project
// but truly not include these code fragments into library.

// It goals to clarify why we want to active pattern library.
// You can compare the "test" project (contains active pattern version).

using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace csharp_standard_usage_sample
{
    static class Program
    {
        private static string ReadSampleCode()
        {
            using (var fs = Assembly.GetEntryAssembly().GetManifestResourceStream("csharp_standard_usage_sample.Sample.cs"))
            {
                var tr = new StreamReader(fs, Encoding.UTF8);
                return tr.ReadToEnd();
            }
        }

        static void Main(string[] args)
        {
            var sampleCode = ReadSampleCode();

            var tree = (CSharpSyntaxTree) CSharpSyntaxTree.ParseText(sampleCode);
            var root = (CompilationUnitSyntax)tree.GetRoot();

            // Too complex if we have to analyze roslyn AST using C#...

            if (root.Usings.Any(u =>
            {
                var idName = u.Name as IdentifierNameSyntax;
                if (idName != null)
                {
                    var syntaxToken = idName.Identifier.Text;
                    if (syntaxToken == "System")
                    {
                        return true;
                    }
                }
                return false;
            }))
            {
                if (root.Members.Any(m =>
                {
                    var nameDecl = m as NamespaceDeclarationSyntax;
                    if (nameDecl != null)
                    {
                        var name = nameDecl.Name as IdentifierNameSyntax;
                        if (name != null)
                        {
                            if (name.Identifier.Text == "SampleNamespace")
                            {
                                if (nameDecl.Members.Any(m2 =>
                                {
                                    var classDecl = m2 as ClassDeclarationSyntax;
                                    if (classDecl != null)
                                    {
                                        var name2 = classDecl.Identifier.Text;
                                        if (name2 == "SampleClass")
                                        {
                                            return true;
                                        }
                                    }
                                    return false;
                                }))
                                {
                                    // ...
                                }
                            }
                        }
                    }
                    return false;
                }))
                {
                    // ...
                }
            }
        }
    }
}
