using System;
using System.Collections.Generic;
using System.IO;

namespace LeetCodeScaffolder
{
    class Program
    {
        const string BASE_DIRECTORY = "C:\\Users\\ian.finlay\\source\\repos\\LeetCode";

        static void Main(string[] args)
        {

            Console.WriteLine("namespace:");
            string nameSpace = Console.ReadLine();
            string path = Path.Combine(BASE_DIRECTORY, "LeetCodeSolutionLibrary", nameSpace);
            while (!Directory.Exists(path))
            {
                Console.WriteLine($"The namespace \"{nameSpace}\" doesn't exist, would you like to create it? (Y/N):");
                string response = Console.ReadLine();
                if (response.ToLower() == "y")
                {
                    break;
                }
                else if (response.ToLower() == "n")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid response. Enter Y or N.");
                }
            }

            Console.WriteLine("url:");
            string url = Console.ReadLine();

            Console.WriteLine("class name:");
            string className = Console.ReadLine();

            Console.WriteLine("method signature: example - \"int MethodName(string param1, int param2)\"");
            string methodSignature = Console.ReadLine();

            var files = new Dictionary<string, FileInfo>();

            files.Add(
                "SolutionClass", 
                new FileInfo(Path.Combine(BASE_DIRECTORY, "LeetCodeSolutionLibrary", nameSpace, $"{className}.cs")));

            files.Add(
                "TestClass",
                new FileInfo(Path.Combine(BASE_DIRECTORY, "LeetCodeSolutionLibrary.Tests", nameSpace, $"{className}Tests.cs")));

            foreach (var file in files.Values)
            {
                file.Directory.Create();
            }

            Scaffolder s = new Scaffolder();
            s.Scaffold(files, nameSpace, url, className, methodSignature);
        }
    }
}
