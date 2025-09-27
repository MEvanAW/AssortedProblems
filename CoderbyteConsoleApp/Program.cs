// https://www.hackerrank.com/contests/software-engineer-prep-kit/challenges/count-number-pairs/problem?isFullScreen=true
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
     * Complete the 'countAffordablePairs' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY prices
     *  2. INTEGER budget
     */

    public static int countAffordablePairs(List<int> prices, int budget)
    {
        if (prices.Count < 2)
        {
            return 0;
        }
        int count = 0;
        int halfBudgetCount = 0;
        for (int i = 0; i < prices.Count; ++i)
        {
            if (prices[i] + prices[i] > budget)
            {
                break;
            }
            ++halfBudgetCount;
        }
        if (halfBudgetCount > 1)
        {
            count = halfBudgetCount * (halfBudgetCount - 1) / 2;
        }
        for (int i = 0; i < prices.Count; ++i)
        {
            int limit = budget - prices[i];
            if (limit < prices[i])
            {
                break;
            }
            for (int j = Math.Max(halfBudgetCount, i + 1);  j < prices.Count; ++j)
            {
                if (prices[j] <= limit)
                {
                    ++count;
                }
                else
                {
                    break;
                }
            }
        }
        return count;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int pricesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> prices = new List<int>();

        for (int i = 0; i < pricesCount; i++)
        {
            int pricesItem = Convert.ToInt32(Console.ReadLine().Trim());
            prices.Add(pricesItem);
        }

        int budget = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.countAffordablePairs(prices, budget);

        Console.WriteLine(result);
    }
}