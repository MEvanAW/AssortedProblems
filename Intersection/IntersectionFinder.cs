namespace Intersection
{
    /// <summary>
    /// Class for Intersection Finder https://coderbyte.com/information/Find%20Intersection
    /// </summary>
    public static class IntersectionFinder
    {
        public const string FALSE_STRING = "false";
        const string SEPARATOR = ", ";

        /// <summary>
        /// Finding intersection within an array of number strings.
        /// </summary>
        /// <param name="strArr">Array of number strings</param>
        /// <returns>A comma-separated string containing the numbers that occur in elements of strArr in sorted order. If there is no intersection, return the string false.</returns>
        public static string FindIntersection(string[] strArr)
        {
            if (strArr.Length < 2)
            {
                return FALSE_STRING;
            }
            var intersection = strArr[0].Split(SEPARATOR).Intersect(strArr[1].Split(SEPARATOR));
            if (intersection == null || intersection.Count() == 0)
            {
                return FALSE_STRING;
            }
            return string.Join(',', intersection);
        }
    }
}