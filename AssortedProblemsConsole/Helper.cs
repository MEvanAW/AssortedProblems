using PIdentifier = Palindrome.Identifier;

namespace AssortedProblemsConsole
{
    internal class Helper
    {
        internal const string NULL_STRING_NOTICE_FORMAT = "The {0} cannot be null.";
        internal enum Command: byte
        {
            None,
            FizzBuzz,
            PalindromeCaseSensitive,
            PalindromeCaseInsensitive,
            PalindromeLevel,
            Anagram,
            Codeland,
            Intersection,
            QuestionsMarks
        }
        internal static void NullStringNotice(string fieldName = "word")
        {
            Console.WriteLine(string.Format(NULL_STRING_NOTICE_FORMAT, fieldName));
        }
        internal static void CheckPalindrome(bool isCaseSensitive = true)
        {
            Console.Write("Enter word: ");
            string? word = Console.ReadLine();
            if (word == null)
            {
                NullStringNotice();
            }
            else
            {
                Console.Write(word + " is ");
                bool isp = PIdentifier.IsPalindrome(word, isCaseSensitive);
                Console.WriteLine(isp ? "a palindrome." : "not a palindrome.");
            }
        }
    }
}