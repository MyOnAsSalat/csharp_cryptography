using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Microsoft.CSharp;
using CharpShell;

namespace CharpShellConsole
{
    class Program
    {

        static void Log(string text) 
        {
            Console.WriteLine(text);
        }
        static void Main(string[] args)
        {
            Console.Title = "SharpShell";
            Console.WriteLine("Welcome to SharpShell. Type !help for help.");

            CharpExecuter executer = new CharpExecuter(new ExecuteLogHandler(Log));
            List<string> code = new List<string>();
            while (true)
            {
                Console.Write("csharp> ");
                string line = Console.ReadLine();
                switch (line)
                {
                    case "!run":
                        {
                            executer.FormatSources(code);
                            File.WriteAllText("script.cs", executer.ProgramText);
                            executer.Execute();
                        }
                        break;
                    case "!show":
                        {
                            Console.WriteLine();
                            Console.WriteLine(executer.FormatSources(code));
                            Console.WriteLine();
                        }
                        break;
                    case "!del":
                        code.RemoveAt(code.Count - 1);
                        break;
                    case "!clear":
                        {
                            code = new List<string>();
                            Console.WriteLine("Done.");
                        }
                        break;
                    case "!runsc":
                        {
                            string script = File.ReadAllText("script.cs");
                            executer.Execute(script);
                        }
                        break;
                    case "!help":
                        {
                            string[] commands = new string[]
                                {
                                    "1. Type your code and it will be added in script",
                                    "2. !show will shows your code",
                                    "3. !del remove last line from your code",
                                    "4. !clear remove all lines from your code",
                                    "5. !run will run script in memory and writes it in script.cs",
                                    "6. !runsc will run script.cs",
                                    "Have fun! :)",
                                };
                            foreach (var str in commands)
                                Console.WriteLine(str);
                        }
                        break;
                    default:
                        {
                            code.Add("              " + line);
                        }
                        break;
                }



            }
        }
    }
}
