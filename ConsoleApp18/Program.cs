using System;
using System.Threading;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            WriteConsoleText("Привет", 300);
            Thread.Sleep(1000);
            WriteConsoleText("Как тебя зовут?", 200);
            WriteConsoleText($"Привет {Console.ReadLine()}", 200);
            Console.ReadKey();
        }
        public static void WriteConsoleText(string text, int duration)
        {
            char[] chartext = text.ToCharArray();
            for (int i = 0; i < chartext.Length; i++)
            {
                Console.Write(chartext[i]);
                Thread.Sleep(duration);
            }
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
