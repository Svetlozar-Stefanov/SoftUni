using System;

namespace PersonsInfo
{
    static class Validator
    {
        public static void CheckFirstName(string value)
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            }
        }

        public static void CheckLastName(string value)
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
            }
        }

        public static void CheckAge(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }
        }

        public static void CheckSalary(decimal value)
        {
            if (value < 460)
            {
                throw new ArgumentException("Salary cannot be less than 460 leva!");
            }
        }
    }
}
