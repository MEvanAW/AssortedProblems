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

        /// <summary>
        /// Calculate palindrome level of a string.
        /// </summary>
        /// <param name="a">The string to be calculated its palindrome level.</param>
        /// <returns>The palindrome level of a.</returns>
        public static int CalculatePalindromeLevel(string a)
        {
            if (a == "")
                return 1;
            a = a.Replace(" ", "");
            int len = a.Length;
            int mid = len / 2;
            List<Iterator> iterators = new();
            int temp = len;
            if (temp > 0)
                while (true)
                {
                    iterators.Add(new Iterator(temp - 1));
                    if (temp <= 1)
                        break;
                    if (temp % 2 != 0)
                        temp = temp / 2 + 1;
                    else
                        temp /= 2;
                }
            for (int i = 0; i < mid; i++)
            {
                foreach (Iterator iterator in iterators)
                {
                    if (iterator.PalindromeEnum != PalindromeEnum.None)
                        break;
                    if (char.ToLowerInvariant(a[i]) != char.ToLowerInvariant(a[iterator.Index]))
                    {
                        iterator.PalindromeEnum = PalindromeEnum.False;
                        break;
                    }
                    if (iterator.Index == iterator.Mid)
                    {
                        iterator.PalindromeEnum = PalindromeEnum.True;
                        continue;
                    }
                    iterator.Index--;
                }
            }
            int level = 0;
            foreach (Iterator iterator in iterators)
            {
                if (iterator.PalindromeEnum == PalindromeEnum.False)
                    break;
                else
                    level++;
            }
            if (level == iterators.Count)
                level++;
            return level;
        }

        internal enum PalindromeEnum: byte
        {
            None,
            False,
            True
        }

        internal class Iterator
        {
            internal int Index { get; set; }
            internal PalindromeEnum PalindromeEnum { get; set; }
            internal int Mid { get; private set; }
            internal Iterator(int index)
            {
                Index = index;
                Mid = (index + 1) / 2;
                PalindromeEnum = PalindromeEnum.None;
            }
        }
    }
}