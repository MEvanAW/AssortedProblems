// https://www.hackerrank.com/contests/software-engineer-prep-kit/challenges/lexicographical-letter-combinations-phone-digits/problem?isFullScreen=true
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
    private static readonly Dictionary<char, char[]> _mapping = new()
    {
        { '0' , new char[] { '0' } },
        { '1' , new char[] { '1' } },
        { '2' , new char[] { 'a', 'b', 'c' } },
        { '3' , new char[] { 'd', 'e', 'f' } },
        { '4' , new char[] { 'g', 'h', 'i' } },
        { '5' , new char[] { 'j', 'k', 'l' } },
        { '6' , new char[] { 'm', 'n', 'o' } },
        { '7' , new char[] { 'p', 'q', 'r', 's' } },
        { '8' , new char[] { 't', 'u', 'v' } },
        { '9' , new char[] { 'w', 'x', 'y', 'z' } }
    };

    /*
     * Complete the 'minTasksToCancelForNoConflict' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts STRING digits as parameter.
     */

    public static List<string> minTasksToCancelForNoConflict(string digits)
    {
        var list = new List<string>();
        map(digits, list, 0, string.Empty);
        return list;
    }

    private static void map(string digits, List<string> list, int index, string combination)
    {
        if (index >= digits.Length)
        {
            list.Add(combination);
            return;
        }
        foreach (var c in _mapping[digits[index]])
        {
            map(digits, list, index + 1, combination + c);
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string digits = Console.ReadLine();

        List<string> result = Result.minTasksToCancelForNoConflict(digits);

        Console.WriteLine(String.Join("\n", result));
    }
}
