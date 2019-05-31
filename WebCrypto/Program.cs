using System;
using System.Collections.Generic;
using System.Net;
using CharpShell;
using System.CodeDom.Compiler;
namespace WebCrypto
{
    class Program
    {
        static void Main()
        {
            Encrypt("","","");

            // StartServer();
        }
        private static void StartServer()
        {

            var server = new HttpListener();

            if (!HttpListener.IsSupported) return;
            server.Prefixes.Add(@"http://*:80/csharpcrypto/");
            server.Prefixes.Add(@"http://*:80/csharpcrypto/Encrypt/");
            server.Prefixes.Add(@"http://*:80/csharpcrypto/Decrypt/");
            server.Start();


            while (server.IsListening)
            {
                var context = server.GetContext();
                var request = context.Request;
                var url = request.Url.AbsolutePath;
                Console.WriteLine(url);
                string result = "test";
                switch (url)
                {
                    case "/csharpcrypto/":
                        result = webform;
                        break;
                    case "/csharpcrypto/encrypt/":
                        result = Encrypt(request.QueryString["code"], request.QueryString["text"], request.QueryString["param"]);
                        break;
                    case "/csharpcrypto/decrypt/":
                        result = Decrypt(request.QueryString["code"], request.QueryString["text"], request.QueryString["param"]);
                        break;
                    default:
                        result = "nothing";
                        break;
                }
                var byteArray = System.Text.Encoding.UTF8.GetBytes(result);  
                using (var output = context.Response.OutputStream)
                {
                    output.Write(byteArray, 0, byteArray.Length);
                    output.Close();
                }

            }
        }
        static CharpExecuter cs = new CharpExecuter();
        private const string webform = @"";
        private static string Encrypt(string code, string text, string param)
        {          
            try { cs.FormatSources(code); } catch (Exception ex) { return "error"; };
            return cs.Execute(text, param, Mode.Encrypt);
        }
        private static string Decrypt(string code, string text, string param)
        {
            try { cs.FormatSources(code); } catch (Exception ex) { return "error"; };
            return cs.Execute(text, param, Mode.Decrypt);
        }
    }
}
