# F# Active pattern library for Roslyn Compiler Platform (C#, VB)

"Microsoft.CodeAnalysis.ActivePatterns" is a F#'s active pattern functions library for [The .NET Compiler Platform ("Roslyn")](https://github.com/dotnet/roslyn) compiler platform.
This library auguments for Roslyn AST (Abstract syntax tree nodes) types by F# active pattern functions.

* This library still under construction...

## Status

| Title | Status |
|:----|:----|
| NuGet | [![NuGet](https://img.shields.io/nuget/v/Microsoft.CodeAnalysis.ActivePatterns.svg?style=flat)](https://www.nuget.org/packages/Microsoft.CodeAnalysis.ActivePatterns) |

## Code example

### This code fragment for Roslyn analysis target:

```csharp
using System.Collections.Generic;

namespace SampleNamespace
{
    public sealed class SampleClass
    {
        public SampleClass()
        {
            this.Value = System.DateTime.Now.Tick;
        }

        public long Value
        {
            get;
            set;
        }
    }
}
```

### This code fragment for Roslyn using C#:

```csharp
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

/// Code fragments are how to analysis by Roslyn and C#.
/// (These are not better and rough codes, but maybe longer analysis codes by using C#...)
namespace csharp_sample
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

        private static string TraverseNameSyntax(NameSyntax name)
        {
            if (name is IdentifierNameSyntax idName)
            {
                return idName.Identifier.Text;
            }

            if (name is QualifiedNameSyntax qName)
            {
                return TraverseNameSyntax(qName.Left) + "." + TraverseNameSyntax(qName.Right);
            }

            return string.Empty;
        }

        static void Main(string[] args)
        {
            var sampleCode = ReadSampleCode();

            var tree = (CSharpSyntaxTree) CSharpSyntaxTree.ParseText(sampleCode);
            var root = (CompilationUnitSyntax)tree.GetRoot();

            // Too complex if we have to analyze roslyn AST using C#...

            if (root.Usings.Any(u =>
            {
                var name = TraverseNameSyntax(u.Name);
                return name == "System.Collections.Generic";
            }))
            {
                if (root.Members.Any(m =>
                {
                    if (m is NamespaceDeclarationSyntax nameDecl)
                    {
                        if (nameDecl.Name is IdentifierNameSyntax name)
                        {
                            if (name.Identifier.Text == "SampleNamespace")
                            {
                                if (nameDecl.Members.Any(m2 =>
                                {
                                    if (m2 is ClassDeclarationSyntax classDecl)
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
```

### If you are using for F# and this library:

```fsharp
open System
open System.IO
open System.Reflection
open System.Text

open Microsoft.CodeAnalysis
open Microsoft.CodeAnalysis.CSharp

// This is a namespace for active pattern functions.
open Microsoft.CodeAnalysis.CSharp.Strict

[<EntryPoint>]
let main argv =
    let sampleCode =
        use fs = Assembly.GetEntryAssembly().GetManifestResourceStream "Sample.cs"
        let tr = new StreamReader(fs, Encoding.UTF8)
        tr.ReadToEnd()

    let tree = CSharpSyntaxTree.ParseText sampleCode
    let root = tree.GetRoot() :?> CSharpSyntaxNode
        
    // Roslyn C# AST can handle by F#'s pattern matching.
    // AST types deconstructs by this library's active pattern functions.
    // And syntax node pattern naming is shorter.

    match root with
    | CompilationUnit
       (_, [ UsingDirective(_, _, _, Identifier(["System";"Collections";"Generic"]), _)], _,
         [ NamespaceDeclaration(_,
            Identifier(["SampleNamespace"]), _, _, _,
            [ ClassDeclaration(decl,
                _, Text("SampleClass"), _, _, _, _,
                memberDecls,
                _, _)],
            _, _) ],
         _) ->
            memberDecls
            |> Seq.choose (function
              | PropertyDeclaration(_, typeSyntax, _, Text(id), _, _, _, _) ->
                 Some (typeSyntax, id)
              | _ -> None)
            |> Seq.iter (printf "%A")
            
    | _ -> ()
    0
```

## Platform

* .NET 7, 6, 5
* .NET Standard 2.1, 2.0
* .NET Core 3.1
* .NET Framework 4.8, 4.6.1
* Roslyn (based 4.4.0).

## Additional resources

* ["You will be assimilated. Resistance is futile." - NGK2016B conference (12.17.2016) session slide.](http://www.slideshare.net/kekyo/documents-you-will-be-assimilated-resistance-is-futile)
  * This is a joke session ;)

## License

* Copyright (c) Kouji Matsui
* Under Apache v2 http://www.apache.org/licenses/LICENSE-2.0

## TODO:

* Improvement auto generator for better output.
* Add additional custom functions.

## History

* 0.9.0:
  * Updated for using Roslyn 4.4.0 and .NET 7 SDK.
* 0.8.20:
  * Fixed NamespaceDeclaration matcher.
* 0.8.10:
  * Upgraded Roslyn to 3.6.0.
* 0.8.1:
  * More shorter SyntaxNode related names (ex: CompilationUnitSyntax --> CompilationUnit).
  * Support strict and loose active patterns.
* 0.7.1:
  * Support .NET Standard, .NET Core 2 and F# 4.5 (4.5.2), based Roslyn 2.8.2.
* 0.5.1:
  * Initial packaged release.
