# F# Active pattern functions for Roslyn Compiler Platform

"Microsoft.CodeAnalysis.ActivePatterns" is a F#'s active pattern functions library for [The .NET Compiler Platform ("Roslyn")](https://github.com/dotnet/roslyn) compiler platform.
This library auguments for Roslyn AST (Abstract syntax tree nodes) types by F# active pattern functions.

* This library still under construction...

## Status

| Title | Status |
|:----|:----|
| NuGet (Roslyn 1.x) | [![NuGet Roslyn 1.x](https://img.shields.io/nuget/v/Microsoft.CodeAnalysis.ActivePatterns.svg?style=flat)](https://www.nuget.org/packages/Microsoft.CodeAnalysis.ActivePatterns) |
| CI (AppVeyor) | [![AppVeyor](https://img.shields.io/appveyor/ci/kekyo/Microsoft.CodeAnalysis.ActivePatterns/master.svg)](https://ci.appveyor.com/project/kekyo/Microsoft.CodeAnalysis.ActivePatterns) |

## Code example

### This code fragment for Roslyn analysis target:

```csharp
using System;

namespace SampleNamespace
{
    public sealed class SampleClass
    {
        public SampleClass()
        {
            this.Value = DateTime.Now.Tick;
        }

        public long Value
        {
            get;
            set;
        }
    }
}
```

### This code fragment for using Roslyn by C#:

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
    class Program
    {
        private static string ReadSampleCode()
        {
            using (var fs = Assembly.GetEntryAssembly().GetManifestResourceStream("csharp_sample.Sample.cs"))
            {
                var tr = new StreamReader(fs, Encoding.UTF8);
                return tr.ReadToEnd();
            }
        }

        static void Main(string[] args)
        {
            var sampleCode = ReadSampleCode();

            var tree = CSharpSyntaxTree.ParseText(sampleCode);
            var root = (CompilationUnitSyntax)tree.GetRoot();

            // Check for "using System;"
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
                // Check for "namespace SampleNamespace {...}"
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
                                // Check for "class SampleClass {...}"
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
```

### If you are using for F# and this library:

```fsharp
open System
open System.IO
open System.Reflection
open System.Text
open Microsoft.CodeAnalysis
open Microsoft.CodeAnalysis.CSharp

[<EntryPoint>]
let main argv =
    let sampleCode =
        use fs = Assembly.GetEntryAssembly().GetManifestResourceStream "Sample.cs"
        let tr = new StreamReader(fs, Encoding.UTF8)
        tr.ReadToEnd()

    let tree = CSharpSyntaxTree.ParseText sampleCode
    let root = tree.GetRoot() :?> CSharpSyntaxNode
        
    // Roslyn C# AST can handling by F#'s pattern matching!!
    // (AST types deconstructs by this library's active pattern functions.)
    match root with
    | CompilationUnitSyntax
        (_, [ UsingDirectiveSyntax(_, _, _, IdentifierNameSyntax(TextToken("System")), _)], _,
         [ NamespaceDeclarationSyntax(_,
            IdentifierNameSyntax(TextToken("SampleNamespace")), _, _, _,
            [ ClassDeclarationSyntax(decl,
                _, TextToken("SampleClass"), _, _, _, _,
                memberDecls,
                _, _)],
            _, _) ],
         _) ->
            memberDecls
            |> Seq.choose (function
              | PropertyDeclarationSyntax(_, typeSyntax, _, TextToken(id), _, _, _, _) ->
                 Some (typeSyntax, id)
              | _ -> None)
            |> Seq.iter (printf "%A")
            
    | _ -> ()
0
```

## Platform
* .NET Framework 4.5

## License
* Source code copyright (c) 2016 Kouji Matsui
  * Under Apache v2 http://www.apache.org/licenses/LICENSE-2.0

## TODO:
* Improvement auto generator for better output.
* Add additional custom functions.
* Support Roslyn 2.0.
* Support for F# on .NET Core.

## History
* 0.5.1:
  * Initial packaged release.
