// https://www.hackerrank.com/challenges/one-week-preparation-kit-mini-max-sum/problem
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
    public const string WRITE_FORMAT = "{0} {1}";

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        arr.Sort();
        long min = (long) arr[0] + (long) arr[1] + (long) arr[2] + (long) arr[3];
        long max = (long) arr[1] + (long) arr[2] + (long) arr[3] + (long) arr[4];
        Console.Write(string.Format(WRITE_FORMAT, min, max));
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
