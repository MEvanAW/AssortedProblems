// https://www.hackerrank.com/challenges/one-week-preparation-kit-queue-using-two-stacks/problem
using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        const string ENQUEUE = "1";
        const string DEQUEUE = "2";
        const string PRINT = "3";

        int q = Convert.ToInt32(Console.ReadLine());
        var queue = new Queue<string>();

        for (int testsItr = 0; testsItr < q; ++testsItr)
        {
            string line = Console.ReadLine()!;
            string[] query = line.Split(' ');
            if (query[0] == ENQUEUE)
            {
                queue.Enqueue(query[1]);
            }
            else if (query[0] == DEQUEUE)
            {
                queue.Dequeue();
            }
            else if (query[0] == PRINT)
            {
                Console.WriteLine(queue.Peek());
            }
        }
    }
}