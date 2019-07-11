using System;

namespace Telephony
{
    public class Smartphone : ISurfable, ICallable
    {
        public void CallNumber(string number)
        {
            CheckNumber(number);
            Console.WriteLine($"Calling... {number}");
        }

        public void Surf(string adress)
        {
            CheckAdress(adress);
            Console.WriteLine($"Browsing: {adress}!");
        }

        private void CheckAdress(string adress)
        {
            bool result = true;
            foreach (var letter in adress)
            {
                if (char.IsDigit(letter))
                {
                    result = false;
                    break;
                }
            }
            if (!result)
            {
                throw new InvalidOperationException("Invalid URL!");
            }
        }

        private void CheckNumber(string number)
        {
            bool result = true;
            foreach (var digit in number)
            {
                if (char.IsLetter(digit))
                {
                    result = false;
                    break;
                }
            }

            if (!result)
            {
                throw new InvalidOperationException("Invalid number!");
            }
        }
    }
}
