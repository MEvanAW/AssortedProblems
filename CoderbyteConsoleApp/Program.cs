// https://coderbyte.com/information/Bracket%20Matcher
using System;
using System.Linq;

class MainClass
{
    public const string ZERO = "0";
    public const string ONE = "1";
    public static string BracketMatcher(string str)
    {
        int bracketCount = 0;
        foreach (char c in str)
        {
            if (c == '(')
            {
                ++bracketCount;
            }
            else if (c == ')')
            {
                --bracketCount;
            }
            if (bracketCount < 0)
            {
                return ZERO;
            }
        }
        return bracketCount == 0 ? ONE : ZERO;
    }

    static void Main()
    {

        // keep this function call here
        Console.WriteLine(BracketMatcher(Console.ReadLine()));

    }
}