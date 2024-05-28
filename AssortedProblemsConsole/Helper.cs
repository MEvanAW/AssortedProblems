using PIdentifier = Palindrome.Identifier;

namespace AssortedProblemsConsole
{
    internal class Helper
    {
        internal enum Command: byte
        {
            None,
            FizzBuzz,
            PalindromeCaseSensitive,
            PalindromeCaseInsensitive,
            PalindromeLevel,
            Anagram,
            Codeland,
            Intersection
        }
        internal static void NullStringNotice()
        {
            Console.WriteLine("The word cannot be null.");
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