// https://coderbyte.com/information/Tree%20Constructor
using System;
using System.Linq;

class MainClass
{
    public const string TRUE_STRING = "true";
    public const string FALSE_STRING = "false";

    public static string TreeConstructor(string[] strArr)
    {
        // key = parent; value = children
        var childrenDictionary = new Dictionary<string, List<string>>();
        // key = child; value = parent
        var parentDictionary = new Dictionary<string, string>();
        foreach (var str in strArr)
        {
            var edge = str.Substring(1, str.Length - 2).Split(',');
            if (parentDictionary.ContainsKey(edge[0]))
            {
                // Each child must only have a single parent
                return FALSE_STRING;
            }
            else
            {
                parentDictionary[edge[0]] = edge[1];
            }
            if (childrenDictionary.ContainsKey(edge[1]))
            {
                childrenDictionary[edge[1]].Add(edge[0]);
            }
            else
            {
                childrenDictionary[edge[1]] = new List<string>() { edge[0] };
            }
        }
        var allVertexSet = new HashSet<string>(childrenDictionary.Keys);
        foreach (var children in childrenDictionary.Values)
        {
            allVertexSet.UnionWith(children);
        }
        bool isOrphan = true;
        foreach (var family in childrenDictionary)
        {
            // Each parent must have no more than 2 children
            if (family.Value.Count() > 2)
            {
                return FALSE_STRING;
            }
            // There must be no orphan
            if (!isOrphan)
            {
                continue;
            }
            var treeVertexSet = new HashSet<string>();
            PopulateSet(family.Key, treeVertexSet, childrenDictionary);
            if (allVertexSet.SetEquals(treeVertexSet))
            {
                isOrphan = false;
            }
        }

        return isOrphan ? FALSE_STRING : TRUE_STRING;
    }

    public static void PopulateSet(string root, HashSet<string> set, Dictionary<string,List<string>> dictionary)
    {
        set.Add(root);
        if (dictionary.ContainsKey(root))
        {
            foreach (var child in dictionary[root])
            {
                PopulateSet(child, set, dictionary);
            }
        }
    }

    static void Main()
    {
        var input = new string[] { "(1,2)", "(3,2)", "(2,12)", "(5,2)" };
        // keep this function call here
        Console.WriteLine(TreeConstructor(input));

    }
}