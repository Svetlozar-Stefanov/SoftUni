namespace MergeFiles
{
    using System;
    using System.IO;

    public class Merge
    {
        public static void Main(string[] args)
        {
            string folder = "Resources";
            string fileOne = "FileOne.txt";
            string fileTwo = "FileTwo.txt";
            string output = "Output.txt";

            string pathOne = Path.Combine(folder, fileOne);
            string pathTwo = Path.Combine(folder, fileTwo);
            string outputPath = Path.Combine(folder, output);

            using (var firstReader = new StreamReader(pathOne))
            {
                using (var secondReader = new StreamReader(pathTwo))
                {
                    using (var writer = new StreamWriter(outputPath))
                    {
                        string line1 = firstReader.ReadLine();
                        string line2 = secondReader.ReadLine();

                        while (line1 != null || line2 != null)
                        {
                            if (line1 != null)
                            {
                                writer.WriteLine(line1);
                            }
                            if (line2 != null)
                            {
                                writer.WriteLine(line2);
                            }
                            line1 = firstReader.ReadLine();
                            line2 = secondReader.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
