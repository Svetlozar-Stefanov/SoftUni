using System;

namespace Vehicles
{
    public static class Validator
    {
        internal static void CheckValue(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException();
            }
        }
    }
}
