// https://www.hackerrank.com/contests/software-engineer-prep-kit/challenges/generate-valid-angle-bracket-sequences/problem?isFullScreen=true
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
    static readonly char OPEN = '<';
    static readonly char CLOSE = '>';

    /*
     * Complete the 'generateAngleBracketSequences' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts INTEGER n as parameter.
     */

    public static List<string> generateAngleBracketSequences(int n)
    {
        var list = new List<string>();
        addBracket(list, n, n, string.Empty);
        return list;
    }

    private static void addBracket(List<string> list, int availableOpen, int availableClose, string brackets)
    {
        if (availableOpen <= 0 && availableClose <= 0)
        {
            list.Add(brackets);
            return;
        }
        if (availableOpen > 0)
        {
            addBracket(list, availableOpen - 1, availableClose, brackets + OPEN);
        }
        if (availableClose > availableOpen)
        {
            addBracket(list, availableOpen, --availableClose, brackets + CLOSE);
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> result = Result.generateAngleBracketSequences(n);

        Console.WriteLine(String.Join("\n", result));
    }
}