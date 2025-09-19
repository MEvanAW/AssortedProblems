// https://www.hackerrank.com/contests/software-engineer-prep-kit/challenges/merge-and-sort-intervals/problem?isFullScreen=true
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
     * Complete the 'mergeHighDefinitionIntervals' function below.
     *
     * The function is expected to return a 2D_INTEGER_ARRAY.
     * The function accepts 2D_INTEGER_ARRAY intervals as parameter.
     */

    public static List<List<int>> mergeHighDefinitionIntervals(List<List<int>> intervals)
    {
        if (intervals.Count == 0) return intervals;
        intervals.Sort(delegate (List<int> x, List<int> y)
        {
            return x[0] - y[0];
        });
        var coveredIndex = new HashSet<int>();
        var mergedIntervals = new List<List<int>>();
        for (int i = 0; i < intervals.Count; ++i)
        {
            if (coveredIndex.Contains(i))
            {
                continue;
            }
            var interval = new List<int> { intervals[i][0], intervals[i][1] };
            for (int j = i + 1; j < intervals.Count; ++j)
            {
                if (intervals[j][0] <= interval[1])
                {
                    coveredIndex.Add(j);
                    if (intervals[j][1] > interval[1])
                    {
                        interval[1] = intervals[j][1];
                    }
                }
                else
                {
                    break;
                }
            }
            mergedIntervals.Add(interval);
        }
        return mergedIntervals;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int intervalsRows = Convert.ToInt32(Console.ReadLine().Trim());
        int intervalsColumns = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> intervals = new List<List<int>>();

        for (int i = 0; i < intervalsRows; i++)
        {
            intervals.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(intervalsTemp => Convert.ToInt32(intervalsTemp)).ToList());
        }

        List<List<int>> result = Result.mergeHighDefinitionIntervals(intervals);

        Console.WriteLine(String.Join("\n", result.Select(x => String.Join(" ", x))));
    }
}
