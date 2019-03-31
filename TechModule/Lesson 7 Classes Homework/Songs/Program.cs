using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] songData = Console.ReadLine().Split('_').ToArray();

                songs.Add(new Song(songData[0], songData[1], songData[2]));
            }

            string typeToPrint = Console.ReadLine();

            foreach (var song in songs)
            {
                song.PrintType(typeToPrint);
            }

        }
    }

    class Song
    {
        string Type;
        string Name;
        string Length;

        public Song(string type, string name, string length)
        {
            Type = type;
            Name = name;
            Length = length;
        }

        public void PrintType(string type)
        {
            if (Type == type || type == "all")
            {
                Console.WriteLine(Name);
            }
        }
    }
}
