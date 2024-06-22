// https://www.hackerrank.com/challenges/one-week-preparation-kit-grid-challenge/problem
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
     * Complete the 'gridChallenge' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING_ARRAY grid as parameter.
     */

    public static string gridChallenge(List<string> grid)
    {
        int rowCount = grid.Count();
        for (int row = 0; row < rowCount; ++row)
        {
            var charList = grid[row].ToList();
            charList.Sort();
            grid[row] = string.Concat(charList);
        }
        int colCount = grid[0].Count();
        for (int col = 0; col < colCount; ++col)
        {
            char previous = 'a';
            for (int row = 0; row < rowCount; ++row)
            {
                if (grid[row][col] < previous)
                {
                    return "NO";
                }
                previous = grid[row][col];
            }
        }
        return "YES";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> grid = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string gridItem = Console.ReadLine();
                grid.Add(gridItem);
            }

            string result = Result.gridChallenge(grid);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}