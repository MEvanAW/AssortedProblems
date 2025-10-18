// https://www.hackerrank.com/contests/software-engineer-prep-kit/challenges/place-n-cameras-no-conflict-blocked-grid/problem?isFullScreen=true
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
     * Complete the 'canPlaceSecurityCameras' function below.
     *
     * The function is expected to return a BOOLEAN.
     * The function accepts following parameters:
     *  1. INTEGER N
     *  2. 2D_INTEGER_ARRAY grid
     */

    public static bool canPlaceSecurityCameras(int N, List<List<int>> grid)
    {
        var usedColumns = new HashSet<int>();
        var usedDiagonals = new HashSet<int>();
        var usedAntiDiagonals = new HashSet<int>();

        return recursivePlaceCameras(grid, usedColumns, usedDiagonals, usedAntiDiagonals, 0);
    }

    private static bool recursivePlaceCameras(List<List<int>> grid, HashSet<int> usedColumns, HashSet<int> usedDiagonals, HashSet<int> usedAntiDiagonals, int row)
    {
        if (row == grid.Count)
        {
            return true;
        }
        for (int col = 0; col < grid.Count; ++col)
        {
            if (grid[row][col] == 1 || usedColumns.Contains(col) || usedDiagonals.Contains(row + col) || usedAntiDiagonals.Contains(row - col))
            {
                continue;
            }
            usedColumns.Add(col);
            usedDiagonals.Add(row + col);
            usedAntiDiagonals.Add(row - col);
            if (recursivePlaceCameras(grid, usedColumns, usedDiagonals, usedAntiDiagonals, row + 1))
            {
                return true;
            }
            usedColumns.Remove(col);
            usedDiagonals.Remove(row + col);
            usedAntiDiagonals.Remove(row - col);
        }
        return false;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());

        int gridRows = Convert.ToInt32(Console.ReadLine().Trim());
        int gridColumns = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> grid = new List<List<int>>();

        for (int i = 0; i < gridRows; i++)
        {
            grid.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(gridTemp => Convert.ToInt32(gridTemp)).ToList());
        }

        bool result = Result.canPlaceSecurityCameras(N, grid);

        Console.WriteLine((result ? 1 : 0));
    }
}
