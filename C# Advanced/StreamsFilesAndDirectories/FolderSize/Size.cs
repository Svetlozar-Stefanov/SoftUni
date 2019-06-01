namespace FolderSize
{
    using System;
    using System.IO;

    public class Size
    {
        public static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("TestFolder");
            decimal sum = 0;

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);

                sum += fileInfo.Length;
            }

            sum = sum / 1024 / 1024;

            File.WriteAllText("Output.txt", sum.ToString());
        }
    }
}
