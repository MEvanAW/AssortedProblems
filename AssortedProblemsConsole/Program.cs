using AssortedProblemsConsole;
using FBIdentifier = FizzBuzz.Identifier;
using PIdentifier = Palindrome.Identifier;
using AIdentifier = Anagram.Identifier;

Console.WriteLine("Welcome to Assorted Problems Console.");
bool isExit = false;
while (!isExit)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("0. Exit\t\t1. FizzBuzz");
    Console.WriteLine("2. Palindrome\t3. Anagram");
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
        case "3":
            command = Helper.Command.Anagram;
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
                    Helper.NullStringNotice();
                }
                else
                {
                    Console.Write(word + " is ");
                    bool isp = PIdentifier.IsPalindrome(word);
                    Console.WriteLine(isp ? "A palindrome." : "Not a palindrome.");
                }
            }
            break;
        case Helper.Command.Anagram:
            {
                Console.Write("Enter 1st word: ");
                string? a = Console.ReadLine();
                if (a == null)
                {
                    Helper.NullStringNotice();
                }
                else
                {
                    Console.Write("Enter 2nd word: ");
                    string? b = Console.ReadLine();
                    if (b == null)
                    {
                        Helper.NullStringNotice();
                    }
                    else
                    {
                        Console.WriteLine(AIdentifier.IsAnagram(a, b) ? "An anagram" : "Not an anagram");
                    }
                }
            }
            break;
    }
}
