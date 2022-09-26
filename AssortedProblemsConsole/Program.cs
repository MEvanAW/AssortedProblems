using AssortedProblemsConsole;
using FizzBuzz;

Console.WriteLine("Welcome to Assorted Problems Console.");
bool isExit = false;
while (!isExit)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("0. Exit\t1. FizzBuzz");
    Console.Write("Command: ");
    string line = Console.ReadLine();
    Helper.Command command = Helper.Command.None;
    switch (line)
    {
        case "0":
            isExit = true;
            break;
        case "1":
            command = Helper.Command.FizzBuzz;
            break;
        default:
            Console.WriteLine("The command is not recognized.");
            break;
    }
    if (command == Helper.Command.FizzBuzz)
    {
        for (int i = 1; i <= 100; i++)
        {
            string s = Identifier.TypeToString(Identifier.WhatType(i));
            if (s != "Null")
            {
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
