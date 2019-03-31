using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Old_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            string desieredBook = Console.ReadLine();
            int numOfBooks = int.Parse(Console.ReadLine());
            string currentBook = Console.ReadLine();
            int counter = 1;

            while (currentBook != desieredBook)
            {
                if (counter < numOfBooks)
                {
                    currentBook = Console.ReadLine();
                    counter++;
                }
                else
                {
                    Console.WriteLine($"The book you search is not here!");
                    Console.WriteLine($" You checked {counter} books.");
                    return;
                }
              
            }
            if (currentBook == desieredBook)
            {
                Console.WriteLine($"You checked {counter-1} books and found it.");
            }
        }
    }
}
