// https://www.hackerrank.com/contests/software-engineer-prep-kit/challenges/first-occurrence-in-event-code-log/problem?isFullScreen=true
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
     * Complete the 'findFirstOccurrence' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY nums
     *  2. INTEGER target
     */

    public static int findFirstOccurrence(List<int> nums, int target)
    {
        if (nums.Count == 0) return -1;
        if (nums.Count == 1) return nums[0] == target ? 0 : -1;
        var lowerBound = 0;
        var upperBound = nums.Count - 1;
        var checkingIndex = upperBound / 2;
        while (lowerBound < upperBound)
        {
            int range;
            if (nums[checkingIndex] >= target)
            {
                upperBound = checkingIndex;
                range = upperBound - lowerBound;
                if (range == 1)
                {
                    if (checkingIndex > 0 && nums[checkingIndex - 1] == target)
                    {
                        return --checkingIndex;
                    }
                    else if (nums[checkingIndex] == target)
                    {
                        return checkingIndex;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            else
            {
                lowerBound = checkingIndex;
                range = upperBound - lowerBound;
                if (range == 1)
                {
                    if (nums[checkingIndex] == target)
                    {
                        return checkingIndex;
                    }
                    else if (checkingIndex < nums.Count - 1 && nums[++checkingIndex] == target)
                    {
                        return checkingIndex;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            checkingIndex = (upperBound + lowerBound) / 2;
        }
        return checkingIndex;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int numsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> nums = new List<int>();

        for (int i = 0; i < numsCount; i++)
        {
            int numsItem = Convert.ToInt32(Console.ReadLine().Trim());
            nums.Add(numsItem);
        }

        int target = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.findFirstOccurrence(nums, target);

        Console.WriteLine(result);
    }
}