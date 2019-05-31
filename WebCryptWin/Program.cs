using System;
using System.Net;
using CharpShell;
using System.IO;

namespace WebCryptWin
{
    class Program
    {
        private static string webform => File.ReadAllText(@"crypto_page.html").Replace("\n", " ");
        static void Main()
        {

            StartServer();
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
                string result = "test";
                var parts = new StreamReader(context.Request.InputStream).ReadToEnd().Split(new string[] { "%splitter%" }, StringSplitOptions.None);
                switch (url)
                {
                    case "/csharpcrypto/":
                        result = webform;
                        Console.WriteLine("/csharpcrypto/");
                        break;
                    case "/csharpcrypto/encrypt/":
                        result = Encrypt(parts[0], parts[1], parts[2]);
                        Console.WriteLine("/csharpcrypto/encrypt/");
                        break;
                    case "/csharpcrypto/decrypt/":
                        result = Decrypt(parts[0], parts[1], parts[2]);
                        Console.WriteLine("/csharpcrypto/decrypt/");
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

        private static string Encrypt(string code, string text, string param)
        {
            try { cs.FormatSources(code);
                return cs.Execute(text, param, Mode.Encrypt);
            }
            catch (Exception ex) { return "error"; };
        }
        private static string Decrypt(string code, string text, string param)
        {
            try { cs.FormatSources(code);
                return cs.Execute(text, param, Mode.Decrypt);
            }
            catch (Exception ex) { return "error"; };
        }
        

    }
}
