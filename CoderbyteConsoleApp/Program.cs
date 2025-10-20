// https://www.hackerrank.com/contests/software-engineer-prep-kit/challenges/ways-to-fill-slots-single-double-coverage/problem?isFullScreen=true
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
using System.Numerics;

class Result
{
    private static readonly int[] _fibonacci = new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };

    /*
     * Complete the 'countInstallationSequences' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER n as parameter.
     */

    public static string countInstallationSequences(int n)
    {
        if (n < _fibonacci.Length)
        {
            return _fibonacci[n].ToString();
        }
        decimal operand = _fibonacci[_fibonacci.Length - 2];
        decimal sum = _fibonacci[_fibonacci.Length - 1];
        int i = _fibonacci.Length;
        for (; i <= Math.Min(n, 138); ++i)
        {
            decimal temp = sum;
            sum += operand;
            operand = temp;
        }
        if (i == n + 1)
        {
            return sum.ToString();
        }
        BigInteger bigOperand = new(operand);
        BigInteger bigSum = new(sum);
        for (; i <= n; ++i)
        {
            BigInteger temp = bigSum;
            bigSum += bigOperand;
            bigOperand = temp;
        }
        return bigSum.ToString();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.countInstallationSequences(n);

        Console.WriteLine(result);
    }
}
