using System;

namespace BalancedBrakets
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            bool balanced = true;
            string lastBracket = "";

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                if (input == "(")
                {
                    if (lastBracket == "(")
                    {
                        balanced = false;
                        break;
                    }
                    lastBracket = "(";
                }
                else if (input == ")")
                {
                    if (lastBracket != "(")
                    {
                        balanced = false;
                        break;
                    }
                    lastBracket = ")";
                }
            }
            if (lastBracket == "(")
            {
                balanced = false;
            }

            if (balanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
