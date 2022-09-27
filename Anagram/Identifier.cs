namespace Anagram
{
    /// <summary>
    /// Class to identify whether 2 strings are anagrams or not.
    /// </summary>
    public static class Identifier
    {
        /// <summary>
        /// Identifies whether the 2 parameters are anagrams or not.
        /// </summary>
        /// <param name="a">The first string.</param>
        /// <param name="b">The second string.</param>
        /// <returns>Whether the 2 parameters are anagrams or not.</returns>
        public static bool IsAnagram(string a, string b)
        {
            if (a.Length != b.Length)
                return false;
            Dictionary<char, byte> aCharMap = new();
            Dictionary<char, byte> bCharMap = new();
            foreach (char c in a)
            {
                try { aCharMap.Add(c, 1); }
                catch { aCharMap[c]++; }
            }
            foreach (char c in b)
            {
                try { bCharMap.Add(c, 1); }
                catch { bCharMap[c]++; }
            }
            foreach (KeyValuePair<char,byte> pair in aCharMap)
            {
                byte count = 0;
                try
                {
                    count = bCharMap[pair.Key];
                    bCharMap.Remove(pair.Key);
                }
                catch { return false; }
                if (count != pair.Value)
                {
                    return false;
                }
            }
            if (bCharMap.Any())
                return false;
            return true;
        }
    }
}