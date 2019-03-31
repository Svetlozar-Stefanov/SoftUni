using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool length = CheckLength(password);
            bool isLettersAndNumOnly = CheckStringConsistency(password);
            bool hasTwoNum = CheckNumbers(password);

            if (!length)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isLettersAndNumOnly)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!hasTwoNum)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (length && isLettersAndNumOnly && hasTwoNum)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool CheckNumbers(string password)
        {
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (int.TryParse(password[i].ToString(), out int num))
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool CheckStringConsistency(string password)
        {
            bool value = true;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57 ||
                    password[i] >= 65 && password[i] <= 90 ||
                    password[i] >= 97 && password[i] <= 122)
                {
                    value = true;
                }
                else
                {
                    return false;
                }
            }
            return value;
        }

        private static bool CheckLength(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
