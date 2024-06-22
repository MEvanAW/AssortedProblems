// https://www.hackerrank.com/challenges/one-week-preparation-kit-recursive-digit-sum/problem
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
     * Complete the 'superDigit' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING n
     *  2. INTEGER k
     */

    public static int superDigit(string n, int k)
    {
        long sum = 0;
        foreach (char c in n)
        {
            sum += long.Parse(c.ToString());
        }
        sum *= k;
        return Convert.ToInt32(Recurse(sum));
    }

    private static long Recurse(long sum)
    {
        if (sum < 10)
        {
            return sum;
        }
        string n = sum.ToString();
        long superDigit = 0;
        foreach (char c in n)
        {
            superDigit += long.Parse(c.ToString());
        }
        return Recurse(superDigit);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        string n = firstMultipleInput[0];

        int k = Convert.ToInt32(firstMultipleInput[1]);

        int result = Result.superDigit(n, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
