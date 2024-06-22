// https://www.hackerrank.com/challenges/one-week-preparation-kit-new-year-chaos/problem
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
    private const string TOO_CHAOTIC = "Too chaotic";
    /*
     * Complete the 'minimumBribes' function below.
     *
     * The function accepts INTEGER_ARRAY q as parameter.
     */
    public static void minimumBribes(List<int> q)
    {
        long sum = 0;
        var bribedSet = new HashSet<int>();
        var briberSet = new HashSet<int>();
        for (int i = 0; i < q.Count(); ++i)
        {
            if (q[i] > i + 3)
            {
                Console.WriteLine(TOO_CHAOTIC);
                return;
            }
            int diff = q[i] - i - 1;
            // one-way bribe check
            if (diff > 0)
            {
                sum += diff;
                briberSet.Add(q[i]);
            }
            if (diff != 0)
            {
                if (!briberSet.Contains(i + 1))
                {
                    bribedSet.Add(i + 1);
                }
            }
            // bribe and bribed check
            if (diff <= 0)
            {
                diff = bribedSet.Where(b => b < q[i]).Count();
                if (diff > 2)
                {
                    Console.WriteLine(TOO_CHAOTIC);
                    return;
                }
                sum += diff;
            }
            bribedSet.Remove(q[i]);
        }
        Console.WriteLine(sum);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> q = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();

            Result.minimumBribes(q);
        }
    }
}