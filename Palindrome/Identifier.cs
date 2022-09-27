namespace Palindrome
{
    /// <summary>
    /// Class to identify palindrome.
    /// </summary>
    public static class Identifier
    {
        /// <summary>
        /// Determine whether the string is a palindrome.
        /// </summary>
        /// <param name="s">The string to be determined.</param>
        /// <returns>Whether the string a palindrome or not.</returns>
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