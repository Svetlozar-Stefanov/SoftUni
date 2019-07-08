using System;

namespace BoxData
{
    static class Validator
    {
        internal static void CheckLength(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
        }

        internal static void CheckWidth(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
        }

        internal static void CheckHeight(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
        }
    }
}
