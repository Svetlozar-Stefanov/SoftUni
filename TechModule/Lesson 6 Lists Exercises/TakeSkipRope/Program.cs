using System;
using System.Collections.Generic;
using System.Linq;

namespace TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> decryptedMessage = Console.ReadLine().ToList();

            List<int> numbers = new List<int>();
            for (int i = 0; i < decryptedMessage.Count; i++)
            {
                string letter = decryptedMessage[i].ToString();
                if (int.TryParse(letter, out int num))
                {
                    numbers.Add(num);
                    decryptedMessage.RemoveAt(i);
                    i--;
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else if (i % 2 != 0)
                {
                    skipList.Add(numbers[i]);
                }
            }

            //Console.WriteLine("skip" + String.Join("",skipList));
            //Console.WriteLine("take" + String.Join("", takeList));


            List<char> result = new List<char>();
            for (int f = 0; f < decryptedMessage.Count/takeList.Count; f++)
            {
                for (int i = 0; i < takeList.Count; i++)
                {
                    for (int j = 0; j < takeList[i]; j++)
                    {
                        if (decryptedMessage.Count > 0)
                        {
                            result.Add(decryptedMessage[0]);
                            decryptedMessage.RemoveAt(0);
                            //Console.WriteLine(String.Join("", decryptedMessage));
                            //Console.WriteLine(string.Join("",result));
                        }
                    }
                    for (int k = 0; k < skipList[i]; k++)
                    {
                        if (decryptedMessage.Count > 0)
                        {
                            decryptedMessage.RemoveAt(0);
                            //Console.WriteLine(String.Join("", decryptedMessage));
                        }
                    }
                }
            }
            Console.WriteLine(String.Join("",result));
        }
    }
}
