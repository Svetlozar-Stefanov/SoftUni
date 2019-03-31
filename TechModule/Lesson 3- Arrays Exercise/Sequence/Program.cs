using System;
using System.Linq;

namespace Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string sequence = "";

            for (int i = 0; i < array.Length; i++)
            {
                string tempSequence = array[i].ToString();
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        tempSequence +=" " + array[j].ToString();
                    }
                    else
                    {
                        break;
                    }
                }
                if (tempSequence.Length > sequence.Length)
                {
                    sequence = tempSequence;
                }
            }
            Console.WriteLine(sequence);

        }
    }
}
