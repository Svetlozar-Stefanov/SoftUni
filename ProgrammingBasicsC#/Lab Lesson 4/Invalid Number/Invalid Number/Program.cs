using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (!(number > 99 && number < 201 || number == 0))
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
