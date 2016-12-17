using Microsoft.CodeAnalysis.CSharp;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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
