using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LeetCodeScaffolder
{
    public class Scaffolder
    {
        public void Scaffold(Dictionary<string, FileInfo> files, string nameSpace, string url, string className, string methodSignature)
        {
            ScaffoldSolutionClass(files["SolutionClass"], nameSpace, url, className, methodSignature);
            ScaffoldTestClass(files["TestClass"], nameSpace, url, $"{className}Tests", methodSignature);
        }

        public void ScaffoldSolutionClass(FileInfo file, string nameSpace, string url, string className, string methodSignature)
        {
            List<string> lines = new List<string>
            {
                "using System;",
                "",
                $"namespace LeetCodeSolutionLibrary.{nameSpace}",
                "{",
                $"\t//{url}",
                $"\tpublic class {className}",
                "\t{",
                $"\t\tpublic {methodSignature}",
                "\t\t{",
                "\t\t\tthrow new NotImplementedException();",
                "\t\t}",
                "\t}",
                "}"
            };


            File.WriteAllText(file.FullName, string.Join(Environment.NewLine, lines));
        }

        public void ScaffoldTestClass(FileInfo file, string nameSpace, string url, string className, string methodSignature)
        {
            int msIndexStart = methodSignature.IndexOf(' ') + 1;
            int msLength = methodSignature.IndexOf('(') - msIndexStart;

            List<string> lines = new List<string>
            {
                "using System;",
                "using Xunit;",
                "",
                $"namespace LeetCodeSolutionLibrary.Tests.{nameSpace}",
                "{",
                $"\tpublic class {className}",
                "\t{",
                $"\t\t[Theory]",
                $"\t\t[<ClassData or InlineData>]",
                $"\t\tpublic void {methodSignature.Substring(msIndexStart, msLength)}_Should()",
                "\t\t{",
                "\t\t\t//Arrange",
                "\t\t\t//Act",
                "\t\t\t//Assert",
                "\t\t\tthrow new NotImplementedException();",
                "\t\t}",
                "\t}",
                "}"
            };

            File.WriteAllText(file.FullName, string.Join(Environment.NewLine, lines));
        }
    }
}
