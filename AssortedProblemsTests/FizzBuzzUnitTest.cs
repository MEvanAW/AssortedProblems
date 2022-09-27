using FizzBuzz;

namespace AssortedProblemsTests
{
    public class FizzBuzzUnitTest
    {
        [Fact]
        public void FizzTest()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)
                    continue;
                else if (i % 3 == 0)
                    Assert.Equal("Fizz", Identifier.TypeToString(Identifier.WhatType(i)));
            }
        }
        [Fact]
        public void BuzzTest()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    continue;
                else if (i % 5 == 0)
                    Assert.Equal("Buzz", Identifier.TypeToString(Identifier.WhatType(i)));
            }
        }
        [Fact]
        public void FizzBuzzTest()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Assert.Equal("FizzBuzz", Identifier.TypeToString(Identifier.WhatType(i)));
                }
            }
        }
        [Fact]
        public void NeitherTest()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    continue;
                string s = Identifier.TypeToString(Identifier.WhatType(i));
                Assert.True(s != "Fizz" && s != "Buzz" && s != "FizzBuzz");
            }
        }
    }
}