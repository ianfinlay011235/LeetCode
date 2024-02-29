using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LeetCodeScaffolder
{
    class Program
    {
        const string BASE_DIRECTORY = "C:\\Users\\ian.finlay\\source\\repos\\LeetCode";

        static void Main(string[] args)
        {
            try
            {
                Scaffolder scaffolder = new Scaffolder();
                GetScaffoldVariables(scaffolder);
                scaffolder.Scaffold();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void GetScaffoldVariables(Scaffolder scaffolder)
        {
            scaffolder.NameSpace = GetNameSpace();

            Console.WriteLine("url:");
            scaffolder.Url = Console.ReadLine();

            Console.WriteLine("class name:");
            scaffolder.SolutionClassName = Console.ReadLine();
            scaffolder.TestClassName = scaffolder.SolutionClassName + "Tests";

            scaffolder.Files = GetFileInfos(scaffolder);

            Console.WriteLine("method signature: example - \"int MethodName(string param1, int param2)\"");
            string methodSignature = Console.ReadLine();
            AssignMethodVariablesToScaffolder(scaffolder, methodSignature);
        }

        private static string GetNameSpace()
        {
            Console.WriteLine("namespace:");
            string nameSpace = Console.ReadLine();

            if (!Directory.Exists(Path.Combine(BASE_DIRECTORY, "LeetCodeSolutionLibrary", nameSpace)))
            {
                throw new Exception($"Namespace \"{nameSpace}\" doesn't exist.");
            }

            return nameSpace;
        }

        private static void AssignMethodVariablesToScaffolder(Scaffolder scaffolder, string methodSignature)
        {
            scaffolder.MethodReturnType = methodSignature.Substring(0, methodSignature.IndexOf(' '));

            int nameIndexStart = methodSignature.IndexOf(' ') + 1;
            int nameLength = methodSignature.IndexOf('(') - nameIndexStart;
            scaffolder.MethodName = methodSignature.Substring(nameIndexStart, nameLength);

            int parameterIndexStart = methodSignature.IndexOf('(') + 1;
            int paramterLength = methodSignature.IndexOf(')') - parameterIndexStart;
            scaffolder.MethodParameters = methodSignature
                .Substring(parameterIndexStart, paramterLength)
                .Split(", ")
                .ToList();
        }

        private static Dictionary<string, FileInfo> GetFileInfos(Scaffolder scaffolder)
        {
            var fileInfos = new Dictionary<string, FileInfo>();

            fileInfos.Add(
                "Solution",
                new FileInfo(
                    Path.Combine(
                        BASE_DIRECTORY,
                        "LeetCodeSolutionLibrary",
                        scaffolder.NameSpace,
                        $"{scaffolder.SolutionClassName}.cs")));

            fileInfos.Add(
                "Tests",
                new FileInfo(
                    Path.Combine(
                        BASE_DIRECTORY,
                        "LeetCodeSolutionLibrary.Tests",
                        scaffolder.NameSpace,
                        $"{scaffolder.TestClassName}.cs")));

            ValidateFileInfos(fileInfos);

            return fileInfos;
        }

        private static void ValidateFileInfos(Dictionary<string, FileInfo> fileInfos)
        {
            foreach (var file in fileInfos.Values)
            {
                if (file.Exists)
                {
                    throw new Exception("The files that you are trying to scaffold already exist.");
                }
            }
        }
    }
}
