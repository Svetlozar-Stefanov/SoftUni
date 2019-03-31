using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int spareTime = int.Parse(Console.ReadLine());
            double hardwere = double.Parse(Console.ReadLine());
            double program = double.Parse(Console.ReadLine());
            double frape = double.Parse(Console.ReadLine());

            int leftTime = spareTime - 5;
            leftTime -= 6;
            leftTime -= 4;

            double price = (3 * hardwere) + (2 * program) + frape;

            Console.WriteLine($"{price:f2}");
            Console.WriteLine(leftTime);
        }
    }
}
