namespace Palindrome
{
    /// <summary>
    /// Class to identify palindrome.
    /// </summary>
    public static class Identifier
    {
        /// <summary>
        /// Determine whether the string is a palindrome (case sensitive).
        /// </summary>
        /// <param name="s">The string to be determined.</param>
        /// <param name="isCaseSensitive">Whether processed as case sensitive or not.</param>
        /// <returns>Whether the string a palindrome or not.</returns>
        public static bool IsPalindrome(string s, bool isCaseSensitive = true)
        {
            s = s.Replace(" ", "");
            int len = s.Length;
            int mid = len/2;
            if (isCaseSensitive)
            {
                for (int i = 0; i < mid; i++)
                {
                    if (s[i] != s[len - 1 - i])
                        return false;
                }
            }
            else
            {
                for (int i = 0; i < mid; i++)
                {
                    if (char.ToLowerInvariant(s[i]) != char.ToLowerInvariant(s[len - 1 - i]))
                        return false;
                }
            }
            return true;
        }
    }
}