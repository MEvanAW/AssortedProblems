namespace AssortedProblemsConsole
{
    internal class Helper
    {
        internal enum Command: byte
        {
            None,
            FizzBuzz,
            Palindrome,
            Anagram
        }
        internal static void NullStringNotice()
        {
            Console.WriteLine("The word cannot be null.");
        }
    }
}