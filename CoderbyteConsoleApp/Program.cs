// https://www.hackerrank.com/contests/software-engineer-prep-kit/challenges/count-connected-components-in-network/problem?isFullScreen=true
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
//using System.Numerics;

class Result
{

    /*
     * Complete the 'countIsolatedCommunicationGroups' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. 2D_INTEGER_ARRAY links
     *  2. INTEGER n
     */

    public static int countIsolatedCommunicationGroups(List<List<int>> links, int n)
    {
        var setList = new LinkedList<HashSet<int>>();
        var connectedComputers = new bool[n];
        foreach (var link in links)
        {
            connectedComputers[link[0]] = true;
            connectedComputers[link[1]] = true;
            var firstNode = setList.First;
            LinkedListNode<HashSet<int>>? secondNode = null;
            int searchTarget = -1;
            while (firstNode is not null)
            {
                var containsLink0 = firstNode.Value.Contains(link[0]);
                var containsLink1 = firstNode.Value.Contains(link[1]);
                if (containsLink0 && containsLink1)
                {
                    break;
                }
                if (containsLink0 && !containsLink1)
                {
                    secondNode = firstNode.Next;
                    searchTarget = link[1];
                    break;
                }
                else if (!containsLink0 && containsLink1)
                {
                    secondNode = firstNode.Next;
                    searchTarget = link[0];
                    break;
                }
                firstNode = firstNode.Next;
            }
            if (firstNode is null)
            {
                setList.AddLast(new HashSet<int>(new int[] { link[0], link[1] }));
                continue;
            }
            while (secondNode is not null)
            {
                if (secondNode.Value.Contains(searchTarget))
                {
                    firstNode.Value.UnionWith(secondNode.Value);
                    setList.Remove(secondNode);
                    break;
                }
                secondNode = secondNode.Next;
            }
            if (searchTarget >= 0 && secondNode is null)
            {
                firstNode.Value.Add(searchTarget);
            }
        }
        var isolatedComputerCount = connectedComputers.Where((computer) => !computer).Count();
        return setList.Count + isolatedComputerCount;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int linksRows = Convert.ToInt32(Console.ReadLine().Trim());
        int linksColumns = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> links = new List<List<int>>();

        for (int i = 0; i < linksRows; i++)
        {
            links.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(linksTemp => Convert.ToInt32(linksTemp)).ToList());
        }

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.countIsolatedCommunicationGroups(links, n);

        Console.WriteLine(result);
    }
}
