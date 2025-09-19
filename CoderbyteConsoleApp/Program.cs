// https://www.hackerrank.com/contests/software-engineer-prep-kit/challenges/check-palindrome-filter-non-letters/problem?isFullScreen=true
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

    /*
     * Complete the 'isAlphabeticPalindrome' function below.
     *
     * The function is expected to return a BOOLEAN.
     * The function accepts STRING code as parameter.
     */

    public static bool isAlphabeticPalindrome(string code)
    {
        int j = code.Length - 1;
        for (int i = 0; i < code.Length; ++i)
        {
            while (i < code.Length && !char.IsLetter(code[i]))
            {
                ++i;
            }
            if (i >= code.Length)
            {
                break;
            }
            while (j >= 0 && !char.IsLetter(code[j]))
            {
                --j;
            }
            if (j < 0)
            {
                break;
            }
            if (char.ToLowerInvariant(code[i]) != char.ToLowerInvariant(code[j]))
            {
                return false;
            }
            --j;
        }
        return true;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string code = Console.ReadLine();

        bool result = Result.isAlphabeticPalindrome(code);

        Console.WriteLine((result ? 1 : 0));
    }
}
