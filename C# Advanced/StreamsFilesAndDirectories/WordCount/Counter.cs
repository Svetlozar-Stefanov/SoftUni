namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Counter
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            string folder = "Resources";
            string wordsFile = "words.txt";
            string wordsPath = Path.Combine(folder, wordsFile);
            string[] allWords = File.ReadAllText(wordsPath)
                    .ToLower()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in allWords)
            {
                if (!words.ContainsKey(word))
                {
                    words[word] = 0;
                }
            }

            string textFile = "text.txt";
            string textPath = Path.Combine(folder, textFile);
            string[] text = File.ReadAllText(textPath)
                .ToLower()
                .Split(new char[] {' ','.','-',',','!' });

            foreach (var word in allWords)
            {
                foreach (var textWord in text)
                {
                    if (word == textWord)
                    {
                        words[word]++;
                    }
                }
            }

            string outputFile = "Output.txt";
            string outputPath = Path.Combine(folder, outputFile);
            using (var streamWriter = new StreamWriter(outputPath))
            {
                foreach (var word in words.OrderByDescending(x => x.Value))
                {
                    streamWriter.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
