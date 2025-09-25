// https://www.hackerrank.com/contests/software-engineer-prep-kit/challenges/validate-properly-nested-brackets/problem?isFullScreen=true
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
     * Complete the 'areBracketsProperlyMatched' function below.
     *
     * The function is expected to return a BOOLEAN.
     * The function accepts STRING code_snippet as parameter.
     */

    static readonly char BRACKET_OPEN = '(';
    static readonly char BRACKET_CLOSE = ')';
    static readonly char SQUARE_OPEN = '[';
    static readonly char SQUARE_CLOSE = ']';
    static readonly char BRACE_OPEN = '{';
    static readonly char BRACE_CLOSE = '}';

    public static bool areBracketsProperlyMatched(string str)
    {
        int bracketCount = 0;
        int squareCount = 0;
        int braceCount = 0;
        var openerStack = new Stack();
        foreach (char c in str)
        {
            if (c == BRACKET_OPEN)
            {
                ++bracketCount;
                openerStack.Push(c);
            }
            else if (c == SQUARE_OPEN)
            {
                ++squareCount;
                openerStack.Push(c);
            }
            else if (c == BRACE_OPEN)
            {
                ++braceCount;
                openerStack.Push(c);
            }
            try
            {
                if (c == BRACKET_CLOSE)
                {
                    if (openerStack.Pop() as char? != BRACKET_OPEN)
                    {
                        return false;
                    }
                    --bracketCount;
                }
                else if (c == SQUARE_CLOSE)
                {
                    if (openerStack.Pop() as char? != SQUARE_OPEN)
                    {
                        return false;
                    }
                    --squareCount;
                }
                else if (c == BRACE_CLOSE)
                {
                    if (openerStack.Pop() as char? != BRACE_OPEN)
                    {
                        return false;
                    }
                    --braceCount;
                }
            }
            catch (InvalidOperationException)
            {
                return false;
            }
            if (bracketCount < 0 || squareCount < 0 || braceCount < 0)
            {
                return false;
            }
        }
        return bracketCount == 0 && squareCount == 0 && braceCount == 0;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string code_snippet = Console.ReadLine();

        bool result = Result.areBracketsProperlyMatched(code_snippet);

        Console.WriteLine((result ? 1 : 0));
    }
}
