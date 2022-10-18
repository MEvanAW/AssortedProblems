using Palindrome;

namespace AssortedProblemsTests
{
    public class PalindromeUnitTest
    {
        [Fact]
        public void EmptyTest()
        {
            Assert.True(Identifier.IsPalindrome(""));
        }
        [Fact]
        public void RepeatingCharacterTest()
        {
            string s = "";
            for (int i = 0; i < 100; i++)
            {
                s += "a";
                Assert.True(Identifier.IsPalindrome(s));
            }
        }
        [Fact]
        public void FalseTest()
        {
            Assert.False(Identifier.IsPalindrome("palindrome"));
            Assert.False(Identifier.IsPalindrome("fizz"));
            Assert.False(Identifier.IsPalindrome("buzz"));
            Assert.False(Identifier.IsPalindrome("fizzbuzz"));
            Assert.False(Identifier.IsPalindrome("anagram"));
            Assert.False(Identifier.IsPalindrome("kasur"));
            Assert.False(Identifier.IsPalindrome("ever"));
            Assert.False(Identifier.IsPalindrome("init"));
            Assert.False(Identifier.IsPalindrome("fizzi"));
        }
        [Fact]
        public void MiddleTest()
        {
            Assert.True(Identifier.IsPalindrome("aba"));
            Assert.False(Identifier.IsPalindrome("abc"));
            Assert.True(Identifier.IsPalindrome("qqwqq"));
            Assert.False(Identifier.IsPalindrome("qqwee"));
            Assert.True(Identifier.IsPalindrome("wwwewww"));
            Assert.False(Identifier.IsPalindrome("wwwerrr"));
            Assert.True(Identifier.IsPalindrome("eeeereeee"));
            Assert.False(Identifier.IsPalindrome("eeeertttt"));
        }
        [Fact]
        public void NumberTest()
        {
            Assert.True(Identifier.IsPalindrome("1"));
            Assert.True(Identifier.IsPalindrome("121"));
            Assert.True(Identifier.IsPalindrome("12321"));
            Assert.True(Identifier.IsPalindrome("1234321"));
            Assert.True(Identifier.IsPalindrome("123454321"));
            Assert.False(Identifier.IsPalindrome("12"));
            Assert.False(Identifier.IsPalindrome("123"));
            Assert.False(Identifier.IsPalindrome("1234"));
            Assert.False(Identifier.IsPalindrome("12345"));
            Assert.False(Identifier.IsPalindrome("123456"));
            Assert.False(Identifier.IsPalindrome("1234567"));
            Assert.False(Identifier.IsPalindrome("12345678"));
        }
        [Fact]
        public void CommonTest()
        {
            Assert.True(Identifier.IsPalindrome("eve"));
            Assert.True(Identifier.IsPalindrome("ini"));
            Assert.True(Identifier.IsPalindrome("kasurrusak"));
            Assert.True(Identifier.IsPalindrome("kasur rusak"));
            Assert.True(Identifier.IsPalindrome("kasur ini rusak"));
            Assert.True(Identifier.IsPalindrome("anna"));
            Assert.True(Identifier.IsPalindrome("palindromeemordnilap"));
            Assert.True(Identifier.IsPalindrome("fizzif"));
            Assert.True(Identifier.IsPalindrome("fizzzzif"));
            Assert.True(Identifier.IsPalindrome("buzzub"));
            Assert.True(Identifier.IsPalindrome("buzzzzub"));
            Assert.True(Identifier.IsPalindrome("anagrammargana"));
            Assert.True(Identifier.IsPalindrome("olahhalo"));
            Assert.True(Identifier.IsPalindrome("mitomomotim"));
        }
        [Fact]
        public void AlphaNumericalTest()
        {
            Assert.True(Identifier.IsPalindrome("3v3"));
            Assert.True(Identifier.IsPalindrome("a1a"));
            Assert.True(Identifier.IsPalindrome("bb2bb"));
            Assert.True(Identifier.IsPalindrome("cc33cc"));
            Assert.True(Identifier.IsPalindrome("ddd4ddd"));
            Assert.True(Identifier.IsPalindrome("eeee5eeee"));
            Assert.True(Identifier.IsPalindrome("ffffff6ffffff"));
            Assert.True(Identifier.IsPalindrome("k4surrus4k"));
            Assert.True(Identifier.IsPalindrome("k4sur rus4k"));
            Assert.True(Identifier.IsPalindrome("k4sur 1n1 rus4k"));
            Assert.True(Identifier.IsPalindrome("f1zz1f"));
            Assert.False(Identifier.IsPalindrome("p4l1ndr0m3"));
            Assert.False(Identifier.IsPalindrome("f1zz"));
            Assert.False(Identifier.IsPalindrome("bu22"));
            Assert.False(Identifier.IsPalindrome("f122bu22"));
            Assert.False(Identifier.IsPalindrome("4n4gr4m"));
            Assert.False(Identifier.IsPalindrome("k4sur"));
        }

        [Fact]
        public void CaseInsensitiveTest()
        {
            Assert.True(Identifier.IsPalindrome("11 11 11 11 11", false));
            Assert.True(Identifier.IsPalindrome("A man a plan a canal Panama", false));
            Assert.True(Identifier.IsPalindrome("Mr Owl ate my metal worm", false));
            Assert.True(Identifier.IsPalindrome("Do geese see God", false));
            Assert.True(Identifier.IsPalindrome("Was it a car or a cat I saw", false));
            Assert.True(Identifier.IsPalindrome("Rats live on no evil star", false));
            Assert.True(Identifier.IsPalindrome("Live on time emit no evil", false));
            Assert.True(Identifier.IsPalindrome("Step on no pets", false));
            Assert.True(Identifier.IsPalindrome("Hannah", false));
            Assert.True(Identifier.IsPalindrome("Ava", false));
            Assert.True(Identifier.IsPalindrome("Aviva", false));
            Assert.True(Identifier.IsPalindrome("Anna", false));
            Assert.True(Identifier.IsPalindrome("Eve", false));
            Assert.True(Identifier.IsPalindrome("Bob", false));
            Assert.True(Identifier.IsPalindrome("Otto", false));
            Assert.True(Identifier.IsPalindrome("Harrah", false));
            Assert.True(Identifier.IsPalindrome("Renner", false));
            Assert.True(Identifier.IsPalindrome("Salas", false));
            Assert.True(Identifier.IsPalindrome("Nenonen", false));
            Assert.True(Identifier.IsPalindrome("Nisio Isin", false));
            Assert.True(Identifier.IsPalindrome("tattarrattat", false));
            Assert.True(Identifier.IsPalindrome("Able was I ere I saw Elba", false));
            Assert.True(Identifier.IsPalindrome("1", false));
            Assert.True(Identifier.IsPalindrome("121", false));
            Assert.True(Identifier.IsPalindrome("12321", false));
            Assert.True(Identifier.IsPalindrome("1234321", false));
            Assert.True(Identifier.IsPalindrome("123454321", false));
            Assert.False(Identifier.IsPalindrome("12", false));
            Assert.False(Identifier.IsPalindrome("123", false));
            Assert.False(Identifier.IsPalindrome("1234", false));
            Assert.False(Identifier.IsPalindrome("12345", false));
            Assert.False(Identifier.IsPalindrome("123456", false));
            Assert.False(Identifier.IsPalindrome("1234567", false));
            Assert.False(Identifier.IsPalindrome("12345678", false));
            Assert.False(Identifier.IsPalindrome("p4l1ndr0m3", false));
            Assert.False(Identifier.IsPalindrome("f1zz", false));
            Assert.False(Identifier.IsPalindrome("bu22", false));
            Assert.False(Identifier.IsPalindrome("f122bu22", false));
            Assert.False(Identifier.IsPalindrome("4n4gr4m", false));
            Assert.False(Identifier.IsPalindrome("k4sur", false));
        }
    }
}
