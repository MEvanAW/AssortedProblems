// https://www.hackerrank.com/contests/software-engineer-prep-kit/challenges/custom-fibonacci-sequence/problem?isFullScreen=true
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
    private static readonly long[] _fibonacci = new long[] { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };

    /*
     * Complete the 'getAutoSaveInterval' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts INTEGER n as parameter.
     */

    public static long getAutoSaveInterval(int n)
    {
        if (n < _fibonacci.Length)
        {
            return _fibonacci[n];
        }
        long operand = _fibonacci[_fibonacci.Length - 2];
        long sum = _fibonacci[_fibonacci.Length - 1];
        for (int i = _fibonacci.Length; i <= n; ++i)
        {
            long temp = sum;
            sum += operand;
            operand = temp;
        }
        return sum;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        long result = Result.getAutoSaveInterval(n);

        Console.WriteLine(result);
    }
}
