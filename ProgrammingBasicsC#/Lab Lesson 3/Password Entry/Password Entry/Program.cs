using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Entry
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "s3cr3t!P@ssw0rd";

            string passwordEntry = Console.ReadLine();

            if (passwordEntry == password)
            {
                Console.WriteLine("Welcome");
            }

            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
