using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorHtml2
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();

            short option = short.Parse(Console.ReadLine());
            HandlerScreen(option);

        }
        public static void DrawScreen()
        {
            Console.Write("+");
            for (int i = 0; i <= 50; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");

            for (int lines = 0; lines <= 20; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 50; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 50; i++)
            {
                Console.Write("-");
            } Console.Write("+");

            Options();

            
        }
        public static void Options()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("EDITOR HTML");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("============");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("SELECIONE UMA OPÇÃO ABAIXO:");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("1 - NOVO ARQUIVO");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("2 - ABRIR");
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("0 - SAIR");
            Console.SetCursorPosition(3, 12);
            Console.Write("Opção: ");

            /* selecione uma opção. novo arquivo, abrir, sair*/
        }
        public static void HandlerScreen(short option) 
        {
            switch(option)
            {
                case 1: Editor.ShowEdit(); break;
                case 2: Console.WriteLine("..."); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }
}
