using System;

namespace ShoppingSpree
{
    public static class Validator
    {
        internal static void CheckName(string value)
        {
            if (string.IsNullOrEmpty(value) || value == " ")
            {
                throw new ArgumentException("Name cannot be empty");
            }
        }

        internal static void CheckNumValue(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
        }
    }
}
