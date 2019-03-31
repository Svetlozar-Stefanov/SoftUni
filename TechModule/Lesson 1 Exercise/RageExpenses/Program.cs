using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int loses = int.Parse(Console.ReadLine());
            double headset = double.Parse(Console.ReadLine());
            double mouse = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double monitor = double.Parse(Console.ReadLine());

            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;

            for (int i = 1; i <= loses; i++)
            {
                bool trashedHeadset = false;
                bool trashedMouse = false;

                if (i % 2 == 0)
                {
                    headsetCount++;
                    trashedHeadset = true;
                }
                if (i % 3 == 0)
                {
                    mouseCount++;
                    trashedMouse = true;
                }
                if (trashedHeadset && trashedMouse)
                {
                    keyboardCount++;
                }
            }

            double sum = headsetCount * headset + mouseCount * mouse + keyboardCount * keyboard + (keyboardCount / 2) * monitor;

            Console.WriteLine($"Rage expenses: {sum:f2} lv.");
        }
    }
}
