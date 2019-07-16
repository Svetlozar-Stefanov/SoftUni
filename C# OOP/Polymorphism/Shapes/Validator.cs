using System;

namespace Shapes
{
    public static class Validator
    {
        internal static void CheckSide(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException();
            }
        }
    }
}
