namespace Codeland
{
    /// <summary>
    /// Class for Codeland https://coderbyte.com/editor/Codeland%20Username%20Validation:Csharp
    /// </summary>
    public static class UserService
    {
        public const string FALSE_STRING = "false";
        public const string TRUE_STRING = "true";
        
        /// <summary>
        /// Validate username according to the following rules:
        /// 1. The username is between 4 and 25 characters.
        /// 2. It must start with a letter.
        /// 3. It can only contain letters, numbers, and the underscore character.
        /// 4. It cannot end with an underscore character.
        /// </summary>
        /// <param name="username">User name to be validated.</param>
        /// <returns>The string true if the user name is valid, otherwise the string false.</returns>
        public static string CodelandUsernameValidation(string username)
        {
            // Null checking
            if (username is null)
            {
                return FALSE_STRING;
            }
            // First rule checking
            if (username.Length < 4 || username.Length > 25)
            {
                return FALSE_STRING;
            }
            // Second rule checking
            if (!char.IsLetter(username.FirstOrDefault()))
            {
                return FALSE_STRING;
            }
            // Fourth rule checking
            if (username.LastOrDefault() == '_')
            {
                return FALSE_STRING;
            }
            return TRUE_STRING;
        }
    }
}