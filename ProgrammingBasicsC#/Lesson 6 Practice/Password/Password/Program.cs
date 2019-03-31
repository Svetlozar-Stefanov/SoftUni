using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName = Console.ReadLine().ToLower();
            string surname = Console.ReadLine().ToLower();
            string name = firstName + surname;
            int counter = name.Length;
            string password = "";
            int letter = 0;

            for (int i = 0; i < counter; i++)
            {
                letter = name[i] + counter;
                password += (char)letter;
            }
            
            Console.WriteLine(password);
           

        }
    }
}
