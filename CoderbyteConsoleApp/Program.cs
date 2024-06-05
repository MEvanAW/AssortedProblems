// https://coderbyte.com/information/Longest%20Word
using System;
using System.Linq;

class MainClass
{
    public static string LongestWord(string sen)
    {
        var words = sen.Split(' ');
        if (words.Length <= 0)
        {
            return string.Empty;
        }
        int len = words[0].Where(c => !char.IsPunctuation(c)).Count();
        int returnIndex = 0;
        for (int i = 1; i < words.Length; ++i)
        {
            int iLen = words[i].Where(c => !char.IsPunctuation(c)).Count();
            if (iLen > len)
            {
                returnIndex = i;
                len = iLen;
            }
        }
        return words[returnIndex];
    }

    static void Main()
    {

        // keep this function call here
        Console.WriteLine(LongestWord(Console.ReadLine()));

    }
}