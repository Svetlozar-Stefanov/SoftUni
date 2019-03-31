using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBA_Challanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();
            while (input != "Season end")
            {
                if (input.Contains(" -> "))
                {
                    string[] info = input.Split(" -> ");
                    string player = info[0];
                    string position = info[1];
                    int skillLevel = int.Parse(info[2]);

                    if (!players.ContainsKey(player))
                    {
                        players[player] = new Dictionary<string, int>()
                        {
                            {position, skillLevel }
                        };
                    }
                    if (!players[player].ContainsKey(position))
                    {
                        players[player].Add(position, 0);
                    }
                    if (players[player][position] < skillLevel)
                    {
                        players[player][position] = skillLevel;
                    }
                }
                else if (input.Contains(" vs "))
                {
                    string[] info = input.Split(" vs ");
                    string firstPlayer = info[0];
                    string secondPlayer = info[1];
                    if (players.ContainsKey(firstPlayer) && players.ContainsKey(secondPlayer))
                    {
                        bool matching = false;
                        foreach (var position in players[firstPlayer])
                        {
                            if (players[secondPlayer].Keys.Contains(position.Key))
                            {
                                matching = true;
                                break;
                            }
                        }

                        if (matching)
                        {
                            if (players[firstPlayer].Values.Sum() > players[secondPlayer].Values.Sum())
                            {
                                players.Remove(secondPlayer);
                            }
                            else if (players[secondPlayer].Values.Sum() > players[firstPlayer].Values.Sum())
                            {
                                players.Remove(firstPlayer);
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            players = players.OrderByDescending(x => x.Value.Values.Sum())
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var player in players)
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

                var positions = player.Value.ToDictionary(x => x.Key, x => x.Value);

                positions = positions.OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var position in positions)
                {
                    Console.WriteLine($" - {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}
