namespace Anagram
{
    public static class Identifier
    {
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