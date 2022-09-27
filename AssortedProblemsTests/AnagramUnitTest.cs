using Anagram;

namespace AssortedProblemsTests
{
    public class AnagramUnitTest
    {
        [Fact]
        public void SameTest()
        {
            Assert.True(Identifier.IsAnagram("a", "a"));
        }
        [Fact]
        public void FalseTest()
        {
            Assert.False(Identifier.IsAnagram("a", "b"));
            Assert.False(Identifier.IsAnagram("a", "aa"));
            Assert.False(Identifier.IsAnagram("anagram", "anagrama"));
            Assert.False(Identifier.IsAnagram("anagrama", "anagram"));
            Assert.False(Identifier.IsAnagram("anagram", "marganab"));
            Assert.False(Identifier.IsAnagram("anagramb", "margana"));
        }
        [Fact]
        public void CommonTest()
        {
            Assert.True(Identifier.IsAnagram("anagram", "margana"));
            Assert.True(Identifier.IsAnagram("anagram", "managra"));
            Assert.True(Identifier.IsAnagram("anagram", "amanagr"));
            Assert.True(Identifier.IsAnagram("anagram", "ramanag"));
            Assert.True(Identifier.IsAnagram("anagram", "gramana"));
            Assert.True(Identifier.IsAnagram("anagram", "agraman"));
            Assert.True(Identifier.IsAnagram("anagram", "nagrama"));
        }
        [Fact]
        public void NumericTest()
        {
            Assert.True(Identifier.IsAnagram("1234567", "7654321"));
            Assert.False(Identifier.IsAnagram("1234567", "123456"));
            Assert.True(Identifier.IsAnagram("1234567", "7123456"));
            Assert.False(Identifier.IsAnagram("123456", "1234567"));
            Assert.True(Identifier.IsAnagram("1234567", "6712345"));
            Assert.False(Identifier.IsAnagram("1000000", "0111111"));
            Assert.True(Identifier.IsAnagram("1234567", "5671234"));
            Assert.False(Identifier.IsAnagram("1234567", "12345678"));
            Assert.True(Identifier.IsAnagram("1234567", "4567123"));
            Assert.False(Identifier.IsAnagram("12345678", "1234567"));
            Assert.True(Identifier.IsAnagram("1234567", "3456712"));
            Assert.False(Identifier.IsAnagram("10234567", "1234567"));
            Assert.True(Identifier.IsAnagram("1234567", "2345671"));
            Assert.False(Identifier.IsAnagram("1234567", "10234567"));
        }
        [Fact]
        public void AlphaNumericTest()
        {
            Assert.True(Identifier.IsAnagram("4n4gr4m", "m4rg4n4"));
            Assert.True(Identifier.IsAnagram("5n5gr5m", "m5n5gr5"));
            Assert.True(Identifier.IsAnagram("6n6gr6m", "6m6n6gr"));
            Assert.True(Identifier.IsAnagram("7n7gr7m", "r7m7n7g"));
            Assert.False(Identifier.IsAnagram("1n2gr3m", "gr4m5n6"));
            Assert.False(Identifier.IsAnagram("1n1gram", "1graman"));
            Assert.False(Identifier.IsAnagram("1n1gr2m", "n1gr2m2"));
        }
    }
}
