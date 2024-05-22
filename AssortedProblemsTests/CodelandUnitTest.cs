using Codeland;

namespace AssortedProblemsTests
{
    public class CodelandUnitTest
    {
        [Fact]
        public void NullOrEmptyUsernameTest()
        {
            Assert.Equal(UserService.FALSE_STRING, UserService.CodelandUsernameValidation(null));
            Assert.Equal(UserService.FALSE_STRING, UserService.CodelandUsernameValidation(string.Empty));
        }

        [Fact]
        // 1. The username is between 4 and 25 characters.
        public void InvalidUsernameDueToFirstRuleTest()
        {
            Assert.Equal(UserService.FALSE_STRING, UserService.CodelandUsernameValidation("b"));
            Assert.Equal(UserService.FALSE_STRING, UserService.CodelandUsernameValidation("aa_"));
            Assert.Equal(UserService.FALSE_STRING, UserService.CodelandUsernameValidation("h3l"));
        }

        [Fact]
        // 2. It must start with a letter.
        public void InvalidUsernameDueToSecondRuleTest()
        {
            Assert.Equal(UserService.FALSE_STRING, UserService.CodelandUsernameValidation("__hello_world12"));
            Assert.Equal(UserService.FALSE_STRING, UserService.CodelandUsernameValidation("_hello_world12"));
            Assert.Equal(UserService.FALSE_STRING, UserService.CodelandUsernameValidation("1hello_world12"));
            Assert.Equal(UserService.FALSE_STRING, UserService.CodelandUsernameValidation("__hello_world"));
            Assert.Equal(UserService.FALSE_STRING, UserService.CodelandUsernameValidation("_hello_world"));
            Assert.Equal(UserService.FALSE_STRING, UserService.CodelandUsernameValidation("1hello_world"));
        }

        [Fact]
        // 3. It can only contain letters, numbers, and the underscore character.
        public void InvalidUsernameDueToThirdRuleTest()
        {
            Assert.Equal(UserService.FALSE_STRING, UserService.CodelandUsernameValidation("u hello_world123"));
            Assert.Equal(UserService.FALSE_STRING, UserService.CodelandUsernameValidation("u__#ello_world123"));
        }

        [Fact]
        // 4. It cannot end with an underscore character.
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
