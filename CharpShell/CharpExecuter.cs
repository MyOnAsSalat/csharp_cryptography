using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Reflection;

namespace CharpShell
{
    public delegate void ExecuteLogHandler(object message);

   public class CharpExecuter
    {

        string programText;

        public static ExecuteLogHandler OnExecute;
        
        public string ProgramText
        {
            get { return programText; }
            set { programText = value; }
        }
        private List<string> refferences = new List<string>();

        public List<string> Refferences
        {
            get { return refferences; }
            set { refferences = value; }
        }

        readonly string header = @"
            using System;
            using System.IO;
            using System.Net;
            using System.Threading;
            using System.Collections.Generic;
            using System.Text;
            using System.Text.RegularExpressions;
            using System.ComponentModel;
            using System.Data;
            using System.Drawing;
            using System.Diagnostics;
            using System.Linq;
            using System.Windows.Forms;

            namespace CScript
            {
                public class Script
                {
                    public static void ScriptMethod()
                    { 
                        Stopwatch sw = new Stopwatch();
                        sw.Start();   
            ";
        readonly string footer = @" sw.Stop();Log(sw.Elapsed.ToString());
                    }
                    static void Log(object message)
                    {
                        if(CharpShell.CharpExecuter.OnExecute != null)
                            CharpShell.CharpExecuter.OnExecute(message);
                    }
                }
            }";


        public CharpExecuter(ExecuteLogHandler onExecute)
        {
            OnExecute += onExecute;
            refferences.AddRange(new string[]
                {
                    "System.dll",
                    "System.Core.dll",
                    "System.Net.dll",
                    "System.Data.dll",
                    "System.Drawing.dll",
                    "System.Windows.Forms.dll",
                    Assembly.GetAssembly(typeof(CharpExecuter)).Location,

                });
            
        }
        public void Execute(List<string> code) 
        {
            FormatSources(code);

        }

        public void Execute() 
        {
            Execute(programText);
        }

        public void Execute(string program)
        {
            var CSHarpProvider = CSharpCodeProvider.CreateProvider("CSharp");
            CompilerParameters compilerParams = new CompilerParameters()
            {
                GenerateExecutable = false,
                GenerateInMemory = true,
            };

            compilerParams.ReferencedAssemblies.AddRange(refferences.ToArray());
            var compilerResult = CSHarpProvider.CompileAssemblyFromSource(compilerParams, program);
            if (compilerResult.Errors.Count == 0)
            {
                OnExecute(string.Concat("Executing...",Environment.NewLine));
                try
                {
                    
                    compilerResult.CompiledAssembly.GetType("CScript.Script").GetMethod("ScriptMethod").Invoke(null, null);
                    OnExecute(string.Empty);
                    OnExecute("Done.");
                }
                catch (Exception e)
                {
                    OnExecute(e.InnerException.Message + "rn" + e.InnerException.StackTrace);
                }
            }
            else
            {
                foreach (var oline in compilerResult.Output)
                    OnExecute(oline);
            }
        }

        public string FormatSources(string text) 
        {
            programText = string.Concat(header, text, footer);
            return programText;
        }
        public string FormatSources(List<string> code)
        {

            StringBuilder sb = new StringBuilder(header);

            foreach (var sc in code)
            {
                sb.AppendLine(sc);
            }
            sb.AppendLine(footer);

            programText = sb.ToString();
            return programText;
        }
    }
}
