// https://www.hackerrank.com/challenges/one-week-preparation-kit-simple-text-editor/problem
using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    const string APPEND = "1";
    const string DELETE = "2";
    const string PRINT = "3";
    //const string UNDO = "4";

    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int Q = int.Parse(Console.ReadLine());
        var ops = new string[Q];
        for (int i = 0; i < Q; ++i)
        {
            ops[i] = Console.ReadLine();
        }
        string S = string.Empty;
        var stack = new Stack<string>();
        stack.Push(S);
        foreach (string op in ops)
        {
            var opArr = op.Split(' ');
            if (opArr[0] == APPEND)
            {
                stack.Push(S);
                S += opArr[1];
            }
            else if (opArr[0] == DELETE)
            {
                stack.Push(S);
                S = S.Remove(S.Length - int.Parse(opArr[1]));
            }
            else if (opArr[0] == PRINT)
            {
                Console.WriteLine(S[int.Parse(opArr[1]) - 1]);
            }
            else
            {
                S = stack.Pop();
            }
        }
    }
}