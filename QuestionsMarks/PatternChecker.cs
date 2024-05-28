namespace QuestionsMarks
{
    /// <summary>
    /// https://coderbyte.com/editor/Questions%20Marks:Csharp
    /// </summary>
    public static class PatternChecker
    {
        public const string FALSE_STRING = "false";
        public const string TRUE_STRING = "true";

        public static string QuestionsMarks(string str)
        {
            string returnStr = FALSE_STRING;
            int operand1 = 0;
            int questionMarkCount = 0;
            bool isFirstChar = true;
            foreach (char c in str)
            {
                if (c == '?')
                {
                    ++questionMarkCount;
                    continue;
                }
                if (char.IsDigit(c))
                {
                    if (isFirstChar)
                    {
                        operand1 = int.Parse(c.ToString());
                        questionMarkCount = 0;
                        isFirstChar = false;
                    }
                    else
                    {
                        int operand2 = int.Parse(c.ToString());
                        if (operand1 + operand2 == 10)
                        {
                            if (questionMarkCount == 3)
                            {
                                returnStr = TRUE_STRING;
                            }
                            else
                            {
                                return FALSE_STRING;
                            }
                        }
                        operand1 = operand2;
                        questionMarkCount = 0;
                    }
                }
            }
            return returnStr;
        }
    }
}