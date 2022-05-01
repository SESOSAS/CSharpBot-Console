using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBot_Console.Internal
{
    internal class cnsl
    {
        /// <summary>
        /// Console output with text
        /// </summary>
        public static void Output(string text)
        {
            Console.WriteLine(text);
        }

        /// <summary>
        /// Console output with arg text
        /// </summary>
        public static void Output(string[] text)
        {
            Console.WriteLine(text);
        }

        /// <summary>
        /// Console output with text and Console color
        /// </summary>
        public static void Output(string text, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }


        /// <summary>
        /// Console output with arg text and Console color
        /// </summary>
        public static void Output(string[] text, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Console Error
        /// </summary>
        public static void Error(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Format("[ERROR]: ", text));
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Console arg Error
        /// </summary>
        public static void Error(string[] text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Format("[ERROR]: ", text));
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Console Warning
        /// </summary>
        public static void Warning(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(string.Format("[WARNING]: ", text));
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Console arg Warning
        /// </summary>
        public static void Warning(string[] text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(string.Format("[WARNING]: ", text));
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Console give back strings written in console
        /// </summary>
        public static string Await()
        {
            return Console.ReadLine();
        }

        /// <summary>
        /// Clears the console
        /// </summary>
        public static void Clear()
        {
            Console.Clear();
        }
    }
}
