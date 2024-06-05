// https://coderbyte.com/information/Bracket%20Combinations
using System;
using System.Linq;

class MainClass
{
    public static int BracketCombinations(int num)
    {
        if (num == 0)
        {
            return 1;
        }
        int validCount = 0;
        int all = 2;
        for (int i = 1; i < num*2; ++i)
        {
            all *= 2;
        }
        for (int i = 1; i < all; ++i)
        {
            string combination = Convert.ToString(Convert.ToUInt32(i), toBase: 2).PadLeft(2*num, '0');
            // 0 is (, 1 is ).
            int count = combination.Where(c => c == '0').Count();
            if (count != num)
            {
                continue;
            }
            if (BracketMatcher(combination))
            {
                validCount++;
            }
        }
        return validCount;
    }

    public static bool BracketMatcher(string str)
    {
        int bracketCount = 0;
        foreach (char c in str)
        {
            if (c == '0')
            {
                ++bracketCount;
            }
            else if (c == '1')
            {
                --bracketCount;
            }
            if (bracketCount < 0)
            {
                return false;
            }
        }
        return bracketCount == 0;
    }

    static void Main()
    {
        int input = 3;
        Console.WriteLine(BracketCombinations(input));
    }
}