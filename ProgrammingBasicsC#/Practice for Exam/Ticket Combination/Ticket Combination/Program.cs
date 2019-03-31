using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;
            string chrSum = "";

            while (num > counter)
            {
                for (char a = 'B'; a <= 76; a++)
                {
                    for (char b = 'f'; b >= 97; b--)
                    {
                        for (char c = 'A'; c <= 67; c++)
                        {
                            for (int d = 1; d <= 10; d++)
                            {
                                for (int e = 10; e >= 1; e--)
                                {
                                    if (a % 2 == 0)
                                    {
                                        sum = a + b + c + d + e;
                                        chrSum = a.ToString() + b.ToString() + c.ToString() + d.ToString() + e.ToString();
                                        counter++;
                                    }
                                    if (num == counter)
                                    {
                                        Console.WriteLine($"Ticket combination: {chrSum}");
                                        Console.WriteLine($"Prize: {sum} lv.");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
