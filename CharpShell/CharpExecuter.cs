using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CSharp;
using System.CodeDom.Compiler;

namespace CharpShell
{

   public class CharpExecuter
   {
       //Код готовый к выполнению
       string formatedProgramText;

       public string LastProgramText
       {
           get { return formatedProgramText; }
       }

       //Список сборок, которые будут подключатся при компиляции
       private List<string> refferences = new List<string>();

       public List<string> Refferences
       {
           get { return refferences; }
           set { refferences = value; }
       }

       //Список using определений, которые будут добавлены начало кода 
       private List<string> usings = new List<string>();

       public List<string> Usings
       {
           get { return usings; }
           set { usings = value; }
       }

       readonly string header = @"
            namespace CScript
            {
            class Basic {}
            ";     
       readonly string footer = @"}";


       public CharpExecuter()
       {
           //Инициализация сборок, которые будут добавлены по умолчанию
           refferences.AddRange(new string[]
                {
                    "System.dll",
                    "System.Core.dll",

                });
           //Инициализация using которые будут добавлены по умолчанию
           usings.AddRange(new string[]
            {
                    "System.Collections.Generic",
                    "System.Text",
                    "System.Text.RegularExpressions",
                    "System.ComponentModel",
                    "System.Linq",
            });
       }
       public string Execute(string text, string param, Mode mode)
       {               
         return Execute(formatedProgramText,text, param, mode);
       }

       public string Execute(string program,string text, string param, Mode mode)
       {
           //Создание класса CSHarpProvider с указанием того, что сборка генерируется в памяти
           var CSHarpProvider = CSharpCodeProvider.CreateProvider("CSharp");
           CompilerParameters compilerParams = new CompilerParameters()
           {
               GenerateExecutable = false,
               GenerateInMemory = true,
           };
           //Добавление сборок для компиляции
           compilerParams.ReferencedAssemblies.AddRange(refferences.ToArray());
           //Компиляция
           var compilerResult = CSHarpProvider.CompileAssemblyFromSource(compilerParams, program);
           if (compilerResult.Errors.Count == 0)
           {
               try
               {
                    //Вызов метода ScriptMethod в сборке которая скомпилировалась params
                    var result = mode == Mode.Encrypt ? 
                        compilerResult.CompiledAssembly.GetType("CScript.Script").GetMethod("Encrypt").Invoke(null, new object[] { text, param })
                        :
                        compilerResult.CompiledAssembly.GetType("CScript.Script").GetMethod("Decrypt").Invoke(null, new object[] { text, param });

                    return (string)result;
                }
               catch (Exception)
               {
                    return null;
               }
           }
           else
           {
                return null;
           }
       }

       //Форматирование кода (добавление предопределенных частей)
       public string FormatSources(string text)
       {
            if (text.Contains("System.")) throw new Exception("'System.' keyword not allowed!");
           string usings = FormatUsings();
           formatedProgramText = string.Concat(usings, header, text, footer);
           return formatedProgramText;
       }

       public string FormatSources(List<string> code)
       {

           StringBuilder sb = new StringBuilder(header);

           foreach (var sc in code)
           {
               sb.AppendLine(sc);
           }
           sb.AppendLine(footer);

           formatedProgramText = sb.ToString();
           return formatedProgramText;
       }

       //Форматирование определений using
       private string FormatUsings()
       {
           StringBuilder sb = new StringBuilder();
           foreach (string using_str in usings)
               sb.AppendFormat("using {0};{1}", using_str, Environment.NewLine);
           return sb.ToString();
       }
   }
    public enum Mode
    {
        Encrypt,
        Decrypt
    }
}
