using AssortedProblemsConsole;
using FBIdentifier = FizzBuzz.Identifier;
using PIdentifier = Palindrome.Identifier;

Console.WriteLine("Welcome to Assorted Problems Console.");
bool isExit = false;
while (!isExit)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("0. Exit\t\t1. FizzBuzz");
    Console.WriteLine("2. Palindrome");
    Console.Write("Enter command: ");
    string? line = Console.ReadLine();
    Helper.Command command = Helper.Command.None;
    switch (line)
    {
        case "0":
            isExit = true;
            break;
        case "1":
            command = Helper.Command.FizzBuzz;
            break;
        case "2":
            command = Helper.Command.Palindrome;
            break;
        default:
            Console.WriteLine("The command is not recognized.");
            break;
    }
    switch (command)
    {
        case Helper.Command.FizzBuzz:
            for (int i = 1; i <= 100; i++)
            {
                string s = FBIdentifier.TypeToString(FBIdentifier.WhatType(i));
                Console.WriteLine(s == "Neither" ? i : s);
            }
            break;
        case Helper.Command.Palindrome:
            {
                Console.Write("Enter word: ");
                string? word = Console.ReadLine();
                if (word == null)
                {
                    Console.WriteLine("The word cannot be null.");
                } else
                {
                    Console.Write(word + " is ");
                    bool isp = PIdentifier.IsPalindrome(word);
                    Console.WriteLine(isp ? "a palindrome." : "not a palindrome");
                }
            }
            break;
    }
}
