using System;
using System.Collections.Generic;

namespace GenericBoxOfString
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Box<double>> boxes = new List<Box<double>>();

            for (int i = 0; i < lines; i++)
            {
                double input = double.Parse(Console.ReadLine());

                boxes.Add(new Box<double>(input));
            }
            double lastInput = double.Parse(Console.ReadLine());
            Console.WriteLine(GreaterCount(boxes,lastInput));
        }

        public static int GreaterCount(List<Box<double>> boxes, double comparator)
        {
            int count = 0;
            foreach ( var box in boxes)
            {
                if (box.Value.CompareTo(comparator) > 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static void Swap(List<Box<int>> boxes, int index1, int index2)
        {
            if (index1 >= 0 && index1 < boxes.Count 
                && index2 >= 0 && index2 < boxes.Count)
            {
                Box<int> temp = boxes[index1];
                boxes[index1] = boxes[index2];
                boxes[index2] = temp;
            }
        }
    }
}
