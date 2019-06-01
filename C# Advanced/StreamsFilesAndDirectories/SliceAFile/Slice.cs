namespace SliceAFile
{
    using System;
    using System.IO;

    public class Slice
    {
        public static void Main(string[] args)
        {
            string folder = "Resources";
            string inputFile = "sliceMe.txt";
            string inputPath = Path.Combine(folder, inputFile);
            int parts = 4;

            using (var fileStream = new FileStream(inputPath,FileMode.Open))
            {
                long size = (long)Math.Ceiling(fileStream.Length / (double)parts);
                byte[] buffer = new byte[size];
                for (int i = 1; i <= parts; i++)
                {
                    string outputFile = $"Part-{i}.txt";
                    string outputPath = Path.Combine(folder,outputFile);

                    using (var newFileStream = new FileStream(outputPath, FileMode.Create))
                    {
                        var text = fileStream.Read(buffer, 0, buffer.Length);
                        newFileStream.Write(buffer, 0, text);
                    }
                }
            }
        }
    }
}
