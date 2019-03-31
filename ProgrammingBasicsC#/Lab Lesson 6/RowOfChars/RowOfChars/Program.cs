using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = "";

            for (int i = 1; i <= n; i++)
            {
                char element = char.Parse(Console.ReadLine());
                if (i == n)
                {
                    result += element;
                    break;
                }
                result += element + " ";
            }
            Console.WriteLine(result + "!");

        }
    }
}
