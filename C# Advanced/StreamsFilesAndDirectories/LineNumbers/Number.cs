namespace LineNumbers
{
    using System;
    using System.IO;

    public class Number
    {
        public static void Main(string[] args)
        {
            string folder = "Resources";
            string inputFile = "Input.txt";
            string inputPath = Path.Combine(folder, inputFile);

            using (var streamReader = new StreamReader(inputPath))
            {
                string outputFile = "Output.txt";
                string outputPath = Path.Combine(folder, outputFile);
                using (var streamWriter = new StreamWriter(outputPath))
                {
                    int counter = 1;
                    string line = streamReader.ReadLine();
                    while (line != null)
                    {
                        streamWriter.WriteLine($"{counter} {line}");
                        line = streamReader.ReadLine();
                        counter++;
                    }
                }
            }
        }
    }
}
