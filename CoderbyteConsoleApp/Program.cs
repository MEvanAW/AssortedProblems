// https://www.hackerrank.com/challenges/one-week-preparation-kit-plus-minus/problem
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
    public const string FORMAT = "F6";

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        // positives, negatives, zeros
        int[] counts = new int[3];
        foreach (int i in arr)
        {
            if (i > 0)
            {
                ++counts[0];
            }
            else if (i == 0)
            {
                ++counts[2];
            }
            else
            {
                ++counts[1];
            }
        }
        Console.WriteLine(((decimal) counts[0] / arr.Count()).ToString(FORMAT));
        Console.WriteLine(((decimal) counts[1] / arr.Count()).ToString(FORMAT));
        Console.WriteLine(((decimal) counts[2] / arr.Count()).ToString(FORMAT));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
