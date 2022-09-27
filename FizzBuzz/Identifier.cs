namespace FizzBuzz
{
    /// <summary>
    /// Static class to identify whether a number is Fizz, Buzz, FizzBuzz, or Neither.
    /// </summary>
    public static class Identifier
    {
        /// <summary>
        /// May contain Fizz, Buzz, FizzBuzz, Neither, or Null
        /// </summary>
        public enum Type: byte
        {
            Null,
            Neither,
            Fizz,
            Buzz,
            FizzBuzz
        }
        /// <summary>
        /// Determines the type of a number.
        /// </summary>
        /// <param name="num">The int to be determined its type.</param>
        /// <returns>Type of the number.</returns>
        public static Type WhatType(int num)
        {
            if (num % 3 == 0)
            {
                if (num % 5 == 0)
                {
                    return Type.FizzBuzz;
                }
                return Type.Fizz;
            }
            if (num % 5 == 0)
            {
                return Type.Buzz;
            }
            return Type.Neither;
        }
        /// <summary>
        /// Converts type to string.
        /// </summary>
        /// <param name="type">Type of a number.</param>
        /// <returns>string representation of the type.</returns>
        public static string TypeToString(Type type)
        {
            switch (type)
            {
                case Type.Neither:
                    return "Neither";
                case Type.Fizz:
                    return "Fizz";
                case Type.Buzz:
                    return "Buzz";
                case Type.FizzBuzz:
                    return "FizzBuzz";
                default:
                    return "Null";
            }
        }
    }
}