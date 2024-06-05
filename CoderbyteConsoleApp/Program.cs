// https://coderbyte.com/information/Min%20Window%20Substring
using System;
using System.Linq;

class MainClass
{
    public static string MinWindowSubstring(string[] strArr)
    {
        var kDictionary = new Dictionary<char, int>();
        var returnString = strArr[0];
        foreach (var c in strArr[1])
        {
            if (!kDictionary.ContainsKey(c))
            {
                kDictionary[c] = 1;
            }
            else
            {
                ++kDictionary[c];
            }
        }
        for (int i = 0; i <= strArr[0].Length - strArr[1].Length; ++i)
        {
            if (!kDictionary.ContainsKey(strArr[0][i]))
            {
                continue;
            }
            for (int j = strArr[1].Length; j <= strArr[0].Length - i; ++j)
            {
                var substring = strArr[0].Substring(i, j);
                bool isValid = true;
                foreach (var key in kDictionary.Keys)
                {
                    if (substring.Where(c => c == key).Count() < kDictionary[key])
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid && substring.Length < returnString.Length)
                {
                    returnString = substring;
                    break;
                }
            }
        }
        return returnString;
    }

    static void Main()
    {
        var input = new string[] { "aaffsfsfasfasfasfasfasfacasfafe", "fafe" };
        // keep this function call here
        Console.WriteLine(MinWindowSubstring(input));

    }
}