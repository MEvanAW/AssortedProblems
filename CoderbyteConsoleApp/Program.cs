// https://www.hackerrank.com/contests/software-engineer-prep-kit/challenges/maximum-non-overlapping-intervals/problem?isFullScreen=true
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
     * Complete the 'maximizeNonOverlappingMeetings' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY meetings as parameter.
     */

    public static int maximizeNonOverlappingMeetings(List<List<int>> intervals)
    { 
        if (intervals.Count == 0) return 0;
        intervals.Sort(delegate (List<int> x, List<int> y)
        {
            return x[0] - y[0];
        });
        int count = 1;
        int lastStart = intervals[intervals.Count - 1][0];
        for (int i = intervals.Count - 2; i >= 0; --i)
        {
            if (lastStart >= intervals[i][1])
            {
                lastStart = intervals[i][0];
                ++count;
            }
        }
        return count;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int meetingsRows = Convert.ToInt32(Console.ReadLine().Trim());
        int meetingsColumns = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> meetings = new List<List<int>>();

        for (int i = 0; i < meetingsRows; i++)
        {
            meetings.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(meetingsTemp => Convert.ToInt32(meetingsTemp)).ToList());
        }

        int result = Result.maximizeNonOverlappingMeetings(meetings);

        Console.WriteLine(result);
    }
}
