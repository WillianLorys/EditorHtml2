using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EditorHtml2
{
    public static class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("-----------------");
            Replace(text);
            Console.WriteLine("------------------");
            Console.ReadKey();
        }
        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            //Console.WriteLine(strong);

            var worlds = text.Split(' ');

            for(int i = 0; i < worlds.Length; i++)
            {
                if (strong.IsMatch(worlds[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(worlds[i].Substring(
                        worlds[i].IndexOf('>') + 1,
                        (
                            (worlds[i].LastIndexOf('<') - 1) - 
                            worlds[i].IndexOf('>') 
                            )
                            )
                        );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(worlds[i]);
                    Console.Write(" ");
                }


                
            }

            Console.WriteLine("-----------");
            Console.WriteLine("Digite o caminho do arquivo");
            var path = Console.ReadLine();
            SaveRegex(path, worlds);

            
    
        }

        public static void SaveRegex(string path, string[] variable)
        {
            using(var file = new StreamWriter(path))
            {
                file.Write(variable);
            }
        }

    }
}
