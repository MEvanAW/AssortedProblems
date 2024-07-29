// https://www.hackerrank.com/challenges/one-week-preparation-kit-lego-blocks/problem
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
    const int M = 1000000007;
    // Example cases:
    // m = 1: {1}
    // m = 2: {1,1}, {2}
    // m = 3: {1,1,1}, {1,2}, {2,1}, {3}
    // m = 4: {1,1,1,1}, {1,1,2}, {1,2,1}, {2,1,1}, {1,3}, {3,1}, {2,2}, {4}
    // m = 5: {1,1,1,1,1}, {1,1,1,2}, {1,1,2,1}, {1,2,1,1}, {2,1,1,1}, {1,2,2}, {2,1,2}, {2,2,1}, {1,1,3}, {1,3,1}, {3,1,1}, {2,3}, {3,2}, {1,4}, {4,1}
    static private List<decimal> horizontalPermutations = new List<decimal> { 1, 2, 4, 8, 15, 29, 56, 108, 208, 401, 773, 1490, 2872, 5536, 10671, 20569, 39648, 76424, 147312 };
    static private Dictionary<int, List<decimal>> nToWallPermutationsDict = new();
    static private Dictionary<int, List<decimal>> nToGoodPermutationsDict = new();

    /*
     * Complete the 'legoBlocks' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER m
     */
    public static int legoBlocks(int n, int m)
    {
        if (m > horizontalPermutations.Count)
        {
            // Calculate number of permutations for a line.
            // Each iteration, include 1 width block after all the i-1 width ways plus 2-width block after all the i-2 width ways, etc. up to the 4 width block
            decimal aggregate = horizontalPermutations[horizontalPermutations.Count - 1];
            for (int i = horizontalPermutations.Count; i < m; ++i)
            {
                if (i > 101)
                {
                    aggregate = (aggregate % M + Mod(horizontalPermutations[i - 1] % M - horizontalPermutations[i - 5] % M)) % M;
                }
                else
                {
                    aggregate += (horizontalPermutations[i - 1] - horizontalPermutations[i - 5]);
                }
                horizontalPermutations.Add(aggregate);
            }
        }
        var wallPermutations = new List<decimal>();
        int mIndex = 0;
        bool nExist = nToWallPermutationsDict.ContainsKey(n);
        if (nExist)
        {
            wallPermutations = nToWallPermutationsDict[n];
            mIndex = wallPermutations.Count;
        }
        for (; mIndex < m; ++mIndex)
        {
            wallPermutations.Add(ModulatedPower(horizontalPermutations[mIndex], n));
        }
        if (!nExist) {
            nToWallPermutationsDict[n] = wallPermutations;
        }
        // There is only 1 way to make a width-1 good wall
        var goodPermutations = new List<decimal> { 1 };
        mIndex = 1;
        nExist = nToGoodPermutationsDict.ContainsKey(n);
        if (nExist)
        {
            goodPermutations = nToGoodPermutationsDict[n];
            mIndex = goodPermutations.Count;
        }
        // Any good wall permutation of width < m is essentially one of the invalid left portions of a bad wall, so we subtract those out, multiplied by the permutations
        for (;  mIndex < m; ++mIndex)
        {
            decimal goodPermutation = wallPermutations[mIndex];
            for (int j = 0; j < mIndex; ++j)
            {
                goodPermutation = Mod(goodPermutation % M - ((goodPermutations[j] % M) * (wallPermutations[mIndex - j - 1] % M) % M) % M);
            }
            goodPermutations.Add(goodPermutation);
        }
        if (!nExist)
        {
            nToGoodPermutationsDict[n] = goodPermutations;
        }
        return (int) goodPermutations[m - 1];
    }

    private static decimal ModulatedPower(decimal x, int exp)
    {
        decimal result = 1;
        while (exp > 0)
        {
            if ((exp & 1) == 1)
            {
                result %= M;
                result = (result * x);
            }
            exp >>= 1;
            x %= M;
            x = (x * x);
        }
        return result;
    }

    private static decimal Mod(decimal x)
    {
        decimal mod = x % M;
        return mod >= 0 ? mod : mod + M;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            int result = Result.legoBlocks(n, m);

            Console.WriteLine(result);
        }
    }
}
