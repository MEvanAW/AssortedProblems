// https://www.hackerrank.com/contests/software-engineer-prep-kit/challenges/remove-elements-within-k-distance/problem?isFullScreen=true
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
     * Complete the 'debounceTimestamps' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY timestamps
     *  2. INTEGER K
     */

    public static int debounceTimestamps(List<int> timestamps, int K)
    {
        if (timestamps.Count <= 0)
        {
            return 0;
        }
        int keptIndex = 0;
        int traversingIndex = 1;
        int eliminatedCount = 0;
        while (traversingIndex < timestamps.Count)
        {
            for (traversingIndex = keptIndex + 1; traversingIndex < timestamps.Count; ++traversingIndex)
            {
                if (timestamps[traversingIndex] - timestamps[keptIndex] < K)
                {
                    ++eliminatedCount;
                }
                else
                {
                    keptIndex = traversingIndex;
                    break;
                }
            }
        }
        return timestamps.Count - eliminatedCount;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int timestampsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> timestamps = new List<int>();

        for (int i = 0; i < timestampsCount; i++)
        {
            int timestampsItem = Convert.ToInt32(Console.ReadLine().Trim());
            timestamps.Add(timestampsItem);
        }

        int K = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.debounceTimestamps(timestamps, K);

        Console.WriteLine(result);
    }
}
