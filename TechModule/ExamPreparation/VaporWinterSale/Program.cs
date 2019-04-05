using System;
using System.Collections.Generic;
using System.Linq;

namespace VaporWinterSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> gamesWithoutDlc = new Dictionary<string, double>();
            Dictionary<string, double> gamesWithDlc = new Dictionary<string, double>();

            string[] games = Console.ReadLine().Split(", ");

            foreach (var game in games)
            {
                if (game.Contains("-"))
                {
                    string[] currentGame = game.Split("-");

                    if (!gamesWithoutDlc.ContainsKey(currentGame[0]))
                    {
                        gamesWithoutDlc.Add(currentGame[0],0);
                    }
                    gamesWithoutDlc[currentGame[0]] = double.Parse(currentGame[1]);
                }
                else if (game.Contains(":"))
                {
                    string[] currentDlc = game.Split(":");
                    string gameName = currentDlc[0];
                    string dlcName = currentDlc[1];

                    if (gamesWithoutDlc.ContainsKey(gameName))
                    {
                        string newGame = gameName + " - " + dlcName;
                        if (!gamesWithDlc.ContainsKey(newGame))
                        {
                            gamesWithDlc.Add(newGame, 0);
                        }
                        gamesWithDlc[newGame] = (gamesWithoutDlc[gameName] + (gamesWithoutDlc[gameName] * 0.2));
                        gamesWithoutDlc.Remove(gameName);
                    }
                }
            }

            gamesWithoutDlc = gamesWithoutDlc.ToDictionary(x => x.Key, x => x.Value - (x.Value * 0.2));
            gamesWithDlc = gamesWithDlc.ToDictionary(x => x.Key, x => x.Value - (x.Value * 0.5));

            foreach (var game in gamesWithDlc.OrderBy(x => x.Value))
            {
                Console.WriteLine($"{game.Key} - {game.Value:F2}");
            }
            foreach (var game in gamesWithoutDlc.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{game.Key} - {game.Value:F2}");
            }
        }
    }
}
