using MXGP.Core.Contracts;
using MXGP.IO;
using MXGP.IO.Contracts;
using System;

namespace MXGP.Core
{
    public class Engine : IEngine
    {
        IChampionshipController championshipController;
        IReader reader;
        IWriter writer;

        public Engine()
        {
            championshipController = new ChampionshipController();
            reader = new ConsoleReader();
            writer = new ConsoleWriter();
        }

        public void Run()
        {
            string input = reader.ReadLine();

            while (input != "End")
            {
                string[] info = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = info[0];

                if (command == "CreateRider")
                {
                    string name = info[1];

                    try
                    {
                        writer.WriteLine(championshipController.CreateRider(name));
                    }
                    catch (ArgumentNullException ex)
                    {
                        writer.WriteLine(ex.Message);
                    }
                    catch (InvalidOperationException ex)
                    {
                        writer.WriteLine(ex.Message);
                    }
                    catch (ArgumentException ex)
                    {
                        writer.WriteLine(ex.Message);
                    }
                }
                else if (command == "CreateMotorcycle")
                {
                    string type = info[1] + "Motorcycle";
                    string model = info[2];
                    int horsePower = int.Parse(info[3]);


                    try
                    {
                        writer.WriteLine(championshipController.CreateMotorcycle(type, model, horsePower));
                    }
                    catch (ArgumentNullException ex)
                    {
                        writer.WriteLine(ex.Message);
                    }
                    catch (InvalidOperationException ex)
                    {
                        writer.WriteLine(ex.Message);
                    }
                    catch (ArgumentException ex)
                    {
                        writer.WriteLine(ex.Message);
                    }
                }
                else if (command == "AddMotorcycleToRider")
                {
                    string riderName = info[1];
                    string motorcycleName = info[2];

                    try
                    {
                        writer.WriteLine(championshipController.AddMotorcycleToRider(riderName, motorcycleName));
                    }
                    catch (ArgumentNullException ex)
                    {
                        writer.WriteLine(ex.Message);
                    }
                    catch (InvalidOperationException ex)
                    {
                        writer.WriteLine(ex.Message);
                    }
                    catch (ArgumentException ex)
                    {
                        writer.WriteLine(ex.Message);
                    }
                }
                else if (command == "AddRiderToRace")
                {
                    string raceName = info[1];
                    string riderName = info[2];

                    try
                    {
                        writer.WriteLine(championshipController.AddRiderToRace(raceName, riderName));
                    }
                    catch (ArgumentNullException ex)
                    {
                        writer.WriteLine(ex.Message);
                    }
                    catch (InvalidOperationException ex)
                    {
                        writer.WriteLine(ex.Message);
                    }
                    catch (ArgumentException ex)
                    {
                        writer.WriteLine(ex.Message);
                    }
                }
                else if (command == "CreateRace")
                {
                    string name = info[1];
                    int laps = int.Parse(info[2]);

                    try
                    {
                        writer.WriteLine(championshipController.CreateRace(name, laps));
                    }
                    catch (ArgumentNullException ex)
                    {
                        writer.WriteLine(ex.Message);
                    }
                    catch (InvalidOperationException ex)
                    {
                        writer.WriteLine(ex.Message);
                    }
                    catch (ArgumentException ex)
                    {
                        writer.WriteLine(ex.Message);
                    }
                }
                else if (command == "StartRace")
                {
                    string name = info[1];

                    try
                    {
                        writer.WriteLine(championshipController.StartRace(name));
                    }
                    catch (ArgumentNullException ex)
                    {
                        writer.WriteLine(ex.Message);
                    }
                    catch (InvalidOperationException ex)
                    {
                        writer.WriteLine(ex.Message);
                    }
                    catch (ArgumentException ex)
                    {
                        writer.WriteLine(ex.Message);
                    }
                }

                input = reader.ReadLine();
            }
        }
    }
}
