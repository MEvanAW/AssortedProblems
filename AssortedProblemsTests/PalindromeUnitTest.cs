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
    }
}
