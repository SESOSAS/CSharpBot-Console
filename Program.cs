using CSharpBot_API;
using CSharpBot_Console.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CSharpBot_Console
{
    internal class Program
    {
        public static List<string> MenuSetup = new List<string>();

        public static void Main(string[] args)
        {
            if (args.Length > 1)
            {
                cnsl.Error("Can't run a session and use a file!");
            }
            GenerateMenu();
            Menu();
        }

        public static void GenerateMenu()
        {
            MenuSetup.Add("Options: \n - Start\n - Stop\n - RPC\n - Send *channelID* *text*\n - Exit");
        }

        public static void Menu()
        {
            cnsl.Clear();
            foreach (string s in MenuSetup)
            {
                cnsl.Output(s);
            }
            string input = cnsl.Await();
            string[] inputArgs = cnsl.Await().Split(" ");
            string inputArgsStringPOne = input.Replace(inputArgs[0], "").Replace(inputArgs[1], "");
            string command = inputArgs[0].ToLower();
            switch (command)
            {
                case "start":
                    DBot.DCClientStart();
                    Menu();
                    break;
                case "stop":
                    DBot.DCClientStop();
                    Menu();
                    break;
                case "rpc":
                    Menu();
                    break;
                case "send":
                    DBot.SendMessage(inputArgs[1], inputArgsStringPOne);
                    Menu();
                    break;
                case "exit":
                    DBot.DCClientStop();
                    Process.GetCurrentProcess().Kill();
                    break;
                default:
                    Menu();
                    break;
            }
        }
    }
}
