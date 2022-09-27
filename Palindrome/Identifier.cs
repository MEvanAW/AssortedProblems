namespace Palindrome
{
    public static class Identifier
    {
        public static bool IsPalindrome(string s)
        {
            int len = s.Length;
            int mid = len/2;
            for (int i = 0; i < mid; i++)
            {
                if (s[i] != s[len - 1 - i])
                    return false;
            }
            return true;
        }
    }
}