using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LeetCodeScaffolder
{
    public class Scaffolder
    {
        public Dictionary<string, FileInfo> Files { get; set; }
        public string NameSpace { get; set; }
        public string Url { get; set; }
        public string SolutionClassName { get; set; }
        public string TestClassName { get; set; }
        public string MethodName { get; set; }
        public string MethodReturnType { get; set; }
        public List<string> MethodParameters { get; set; }

        public string MethodParameterTypes 
        { 
            get => string.Join(", ", MethodParameters.Select(p => p.Split(' ')[0])); 
        }
        public string MethodParameterNames 
        { 
            get => string.Join(", ", MethodParameters.Select(p => p.Split(' ')[1])); 
        }

        public void Scaffold()
        {
            ScaffoldSolutionClass();
            ScaffoldTestClass();
        }

        public void ScaffoldSolutionClass()
        {
            List<string> lines = new List<string>
            {
                "using System;",
                "using System.Collections.Generic;",
                "using System.Linq;",
                "",
                $"namespace LeetCodeSolutionLibrary.{NameSpace}",
                "{",
                $"\t//{Url}",
                "",
                $"\tpublic class {SolutionClassName}",
                "\t{",
                "\t\t/*",
                "\t\t * Time Complexity: O()",
                "\t\t * Space Complexity: O()",
                "\t\t */",
                $"\t\tpublic {MethodReturnType} {MethodName}({string.Join(", ", MethodParameters)})",
                "\t\t{",
                "\t\t\tthrow new NotImplementedException();",
                "\t\t}",
                "\t}",
                "}"
            };


            File.WriteAllText(Files["Solution"].FullName, string.Join(Environment.NewLine, lines));
        }

        public void ScaffoldTestClass()
        {
            List<string> lines = new List<string>
            {
                "using System;",
                $"using LeetCodeSolutionLibrary.{NameSpace};",
                "using Xunit;",
                "",
                $"namespace LeetCodeSolutionLibrary.Tests.{NameSpace}",
                "{",
                $"\tpublic class {TestClassName}",
                "\t{",
                $"\t\t[Theory]",
                $"\t\t[InlineData()]",
                $"\t\tpublic void {MethodName}_Should...({MethodReturnType} expected, {string.Join(", ", MethodParameters)})",
                "\t\t{",
                "\t\t\t//Arrange",
                $"\t\t\t{SolutionClassName} solution = new {SolutionClassName}();",
                $"\t\t\t{MethodReturnType} actual;",
                "\t\t\t",
                "\t\t\t//Act",
                $"\t\t\t actual = solution.{MethodName}({string.Join(", ", MethodParameterNames)});",
                "\t\t\t",
                "\t\t\t//Assert",
                "\t\t\tAssert.Equal(expected, actual);",
                "\t\t}",
                "\t}",
                //TheoryData Implementation
                $"\t//[ClassData(typeof({SolutionClassName}DataGenerator))]",
                $"\t//public class {SolutionClassName}DataGenerator : TheoryData<{MethodReturnType}, {string.Join(", ", MethodParameterTypes)}>",
                "\t//{",
                $"\t//\tpublic {SolutionClassName}DataGenerator()",
                "\t//\t{",
                "\t//\t\tAdd();",
                "\t//\t}",
                "\t//}",
                "}"
            };

            File.WriteAllText(Files["Tests"].FullName, string.Join(Environment.NewLine, lines));
        }
    }
}
