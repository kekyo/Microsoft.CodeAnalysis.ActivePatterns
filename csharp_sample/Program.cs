using Microsoft.CodeAnalysis.CSharp;
using System.IO;
using System.Reflection;
using System.Text;

namespace csharp_sample
{
    class Program
    {
        private static string ReadSampleCode()
        {
            using (var fs = Assembly.GetEntryAssembly().GetManifestResourceStream("Sample.cs"))
            {
                var tr = new StreamReader(fs, Encoding.UTF8);
                return tr.ReadToEnd();
            }
        }

        static void Main(string[] args)
        {
            var sampleCode = ReadSampleCode();

            var tree = CSharpSyntaxTree.ParseText(sampleCode);
            var root = tree.GetRoot();
        }

    }
}
