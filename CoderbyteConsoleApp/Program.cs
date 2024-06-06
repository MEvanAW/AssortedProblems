// https://www.hackerrank.com/challenges/one-week-preparation-kit-time-conversion/problem
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
    public const string ZERO = "00";
    public const string TWELVE = "12";
    public const int AP_INDEX = 8;
    public const char A = 'A';
    public const char P = 'P';

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string hour = s.Substring(0, 2);
        if (hour == TWELVE)
        {
            if (s[8] == A)
            {
                return string.Concat(ZERO, s.Substring(2, 6));
            }
            else
            {
                return string.Concat(TWELVE, s.Substring(2, 6));
            }
        }
        if (s[8] == P)
        {
            return string.Concat(int.Parse(hour)+12, s.Substring(2, 6));
        }
        return s.Substring(0, 8);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        Console.WriteLine(result);
    }
}
