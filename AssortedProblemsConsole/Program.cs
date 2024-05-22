﻿using AssortedProblemsConsole;
using Codeland;
using AIdentifier = Anagram.Identifier;
using FBIdentifier = FizzBuzz.Identifier;
using PIdentifier = Palindrome.Identifier;

Console.WriteLine("Welcome to Assorted Problems Console.");
bool isExit = false;
while (!isExit)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("0. Exit\t\t\t\t1. FizzBuzz");
    Console.WriteLine("2. Palindrome Case Sensitive\t3. Palindrome Case Insensitive");
    Console.WriteLine("4. Calculate Palindrome Level\t5. Anagram");
    Console.WriteLine("6. Codeland");
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
            command = Helper.Command.PalindromeCaseSensitive;
            break;
        case "3":
            command = Helper.Command.PalindromeCaseInsensitive;
            break;
        case "4":
            command = Helper.Command.PalindromeLevel;
            break;
        case "5":
            command = Helper.Command.Anagram;
            break;
        case "6":
            command = Helper.Command.Codeland;
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
        case Helper.Command.PalindromeCaseSensitive:
            Helper.CheckPalindrome(true);
            break;
        case Helper.Command.PalindromeCaseInsensitive:
            Helper.CheckPalindrome(false);
            break;
        case Helper.Command.PalindromeLevel:
            Console.Write("Enter word: ");
            string? word = Console.ReadLine();
            if (word == null)
            {
                Helper.NullStringNotice();
            }
            else
            {
                Console.Write(word + " palindrome level is ");
                int level = PIdentifier.CalculatePalindromeLevel(word);
                Console.WriteLine(level);
            }
            break;
        case Helper.Command.Anagram:
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
            break;
        case Helper.Command.Codeland:
            Console.WriteLine("Enter username: ");
            if (UserService.CodelandUsernameValidation(Console.ReadLine()) == UserService.TRUE_STRING)
            {
                Console.WriteLine("Valid username.");
            }
            else
            {
                Console.WriteLine("Invalid username.");
            }
            break;
    }
}
