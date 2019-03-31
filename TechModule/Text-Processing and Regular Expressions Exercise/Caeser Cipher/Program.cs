using System;
using System.Linq;

namespace Caeser_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().Select(x => (char)(x + 3)).ToArray();

            Console.WriteLine(String.Join("", input));
        }
    }
}
