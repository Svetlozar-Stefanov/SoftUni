using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            string[] input = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            while (input[0].ToLower() != "tournament")
            {
                string trainerName = input[0];
                if (!trainers.Any(t => t.Name == trainerName))
                {
                    Trainer newTrainer = new Trainer(trainerName);
                    trainers.Add(newTrainer);
                }
                Trainer trainer = trainers.Where(t => t.Name == trainerName).FirstOrDefault();
                int indexTrainer = trainers.IndexOf(trainer);
                string pokemonName = input[1];
                string pokemonElement = input[2];
                int pokemonHealth = int.Parse(input[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                trainers[indexTrainer].Pokemons.Add(pokemon);

                input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(p => p.Element.ToLower() == command))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        for (int i = 0; i < trainer.Pokemons.Count; i++)
                        {
                            trainer.Pokemons[i].Health -= 10;

                            if (trainer.Pokemons[i].Health <= 0)
                            {
                                trainer.Pokemons.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                }

                command = Console.ReadLine().ToLower();
            }

            foreach (var trainer in trainers.OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
