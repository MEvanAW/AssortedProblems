// https://www.hackerrank.com/contests/software-engineer-prep-kit/challenges/time-slot-task-pairing/problem?isFullScreen=true
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
     * Complete the 'findTaskPairForSlot' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY taskDurations
     *  2. INTEGER slotLength
     */

    public static List<int> findTaskPairForSlot(List<int> taskDurations, int slotLength)
    {
        var elementToIndexDict = new Dictionary<int, int>();
        for (int i = 0; i < taskDurations.Count; ++i)
        {
            if (taskDurations[i] >= slotLength) // No possible match
            {
                continue;
            }
            int desiredElement = slotLength - taskDurations[i];
            if (elementToIndexDict.ContainsKey(desiredElement))
            {
                return new List<int> { elementToIndexDict[desiredElement], i };
            }
        }
        return new List<int> { -1, -1 };
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int taskDurationsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> taskDurations = new List<int>();

        for (int i = 0; i < taskDurationsCount; i++)
        {
            int taskDurationsItem = Convert.ToInt32(Console.ReadLine().Trim());
            taskDurations.Add(taskDurationsItem);
        }

        int slotLength = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> result = Result.findTaskPairForSlot(taskDurations, slotLength);

        Console.WriteLine(String.Join("\n", result));
    }
}
