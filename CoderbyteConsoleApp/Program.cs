// https://www.hackerrank.com/challenges/one-week-preparation-kit-zig-zag-sequence/problem
using System;
using System.Runtime;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int i = 0; i < t; ++i)
        {
            // Read each test case
            int count = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            // Process
            arr.Sort();
            int mid = count / 2;
            for (int j = 0; j <= mid / 2; ++j)
            {
                int temp = arr[mid + j];
                arr[mid + j] = arr[count - j - 1];
                arr[count - j - 1] = temp;
            }

            // Write each test case
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}