using System.Runtime.CompilerServices;

namespace FizzBuzz
{
    public static class Identifier
    {
        public enum Type: byte
        {
            Null,
            Neither,
            Fizz,
            Buzz,
            FizzBuzz
        }
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