// https://www.hackerrank.com/challenges/one-week-preparation-kit-caesar-cipher-1/problem
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

    /*
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {
        int shift = k % 26;
        string cipherText = string.Empty;
        foreach (char c in s)
        {
            if (char.IsLower(c))
            {
                var cipherC = c + shift;
                if (cipherC > 'z')
                {
                    cipherC -= 26;
                }
                cipherText += Convert.ToChar(cipherC);
            }
            else if (char.IsUpper(c))
            {
                var cipherC = c + shift;
                if (cipherC > 'Z')
                {
                    cipherC -= 26;
                }
                cipherText += Convert.ToChar(cipherC);
            }
            else
            {
                cipherText += c;
            }
        }
        return cipherText;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.caesarCipher(s, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}