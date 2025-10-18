// https://www.hackerrank.com/contests/software-engineer-prep-kit/challenges/check-valid-anagram/problem?isFullScreen=true
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
     * Complete the 'isAnagram' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. STRING t
     */

    public static int isAnagram(string s, string t)
    {
        var charDictionary = new Dictionary<char, int>();
        foreach (var c in s)
        {
            if (charDictionary.ContainsKey(c))
            {
                ++charDictionary[c];
            }
            else
            {
                charDictionary[c] = 1;
            }
        }
        foreach (var c in t)
        {
            if (charDictionary.ContainsKey(c))
            {
                --charDictionary[c];
            }
            else
            {
                return 0;
            }
        }
        foreach (var kvp in charDictionary)
        {
            if (kvp.Value != 0)
            {
                return 0;
            }
        }
        return 1;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        string t = Console.ReadLine();

        int result = Result.isAnagram(s, t);

        Console.WriteLine(result);
    }
}
