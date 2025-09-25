// https://www.hackerrank.com/contests/software-engineer-prep-kit/challenges/min-tracking-stack/problem?isFullScreen=true
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
    static readonly string PUSH = "pu";
    static readonly string POP = "po";
    static readonly string TOP = "to";
    static readonly char GET_MIN = 'g';
    static readonly char SEPARATOR = ' ';

    /*
     * Complete the 'processCouponStackOperations' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts STRING_ARRAY operations as parameter.
     */

    public static List<int> processCouponStackOperations(List<string> operations)
    {
        var result = new List<int>();
        var stack = new Stack<int>();
        var minStack = new Stack<int[]>();
        var currentMin = new int[] { int.MaxValue, 0 };
        foreach (var operation in operations)
        {
            if (operation.StartsWith(PUSH))
            {
                int operand = Convert.ToInt32(operation.Split(SEPARATOR)[1]);
                if (operand < currentMin[0])
                {
                    currentMin = new int[] { operand, 1 };
                    minStack.Push(currentMin);
                }
                else if (operand == currentMin[0])
                {
                    ++currentMin[1];
                }
                stack.Push(operand);
            }
            else if (operation.StartsWith(POP))
            {
                if (stack.Pop() == currentMin[0] && --currentMin[1] == 0)
                {
                    minStack.Pop();
                    currentMin = minStack.Peek();
                }
            }
            else if (operation.StartsWith(TOP))
            {
                result.Add(stack.Peek());
            }
            else if (operation.StartsWith(GET_MIN))
            {
                result.Add(currentMin[0]);
            }
        }
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int operationsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> operations = new List<string>();

        for (int i = 0; i < operationsCount; i++)
        {
            string operationsItem = Console.ReadLine();
            operations.Add(operationsItem);
        }

        List<int> result = Result.processCouponStackOperations(operations);

        Console.WriteLine(String.Join("\n", result));
    }
}
