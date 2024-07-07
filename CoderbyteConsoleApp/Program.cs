// https://www.hackerrank.com/challenges/one-week-preparation-kit-balanced-brackets/problem
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    const string NO = "NO";
    const string YES = "YES";

    /*
     * Complete the 'isBalanced' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */
    public static string isBalanced(string s)
    {
        var opening = new char[]
        {
            '(',
            '[',
            '{'
        };
        var stack = new Stack<char>(s.Count()/2);
        foreach (char c in s)
        {
            if (opening.Contains(c))
            {
                stack.Push(c);
            }
            else if (stack.Count <= 0)
            {
                return NO;
            }
            else
            {
                var peek = stack.Peek();
                if (peek == '(' && c != ')')
                {
                    return NO;
                }
                else if (peek == '[' && c != ']')
                {
                    return NO;
                }
                else if (peek == '{' && c != '}')
                {
                    return NO;
                }
                stack.Pop();
            }
        }
        if (stack.Count > 0)
        {
            return NO;
        }
        return YES;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());
        List<string> toBeWritten = new();
        for (int tItr = 0; tItr < t; tItr++)
        {
            string s = Console.ReadLine();

            string result = Result.isBalanced(s);

            toBeWritten.Add(result);
        }
        foreach (var s in toBeWritten)
        {
            Console.WriteLine(s);
        }
    }
}
