﻿using Codeland;

namespace AssortedProblemsTests
{
    public class CodelandTest
    {
        [Fact]
        public void InvalidUsernameDueToFirstRuleTest()
        {
            Assert.Equal(UserService.FALSE_STRING, UserService.CodelandUsernameValidation("aa_"));
            Assert.Equal(UserService.FALSE_STRING, UserService.CodelandUsernameValidation("h3l"));
        }

        [Fact]
        public void InvalidUsernameDueToFourthRuleTest()
        {
            Assert.Equal(UserService.FALSE_STRING, UserService.CodelandUsernameValidation("aa_"));
            Assert.Equal(UserService.FALSE_STRING, UserService.CodelandUsernameValidation("u__hello_"));
        }

        [Fact]
        public void ValidUsernameTest()
        {
            Assert.Equal(UserService.TRUE_STRING, UserService.CodelandUsernameValidation("u__hello_world123"));
        }
    }
}
