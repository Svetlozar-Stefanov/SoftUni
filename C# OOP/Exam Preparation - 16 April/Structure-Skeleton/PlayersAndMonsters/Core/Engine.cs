using PlayersAndMonsters.Core.Contracts;
using PlayersAndMonsters.IO;
using PlayersAndMonsters.IO.Contracts;
using System;

namespace PlayersAndMonsters.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private IManagerController managerController;

        public Engine()
        {
            reader = new ConsoleReader();
            writer = new ConsoleWriter();
            managerController = new ManagerController();
        }

        public Engine(IReader reader, IWriter writer, IManagerController managerController)
        {
            this.reader = reader;
            this.writer = writer;
            this.managerController = managerController;
        }

        public void Run()
        {
            string rawInput = reader.ReadLine();

            while (rawInput != "Exit")
            {
                string[] info = rawInput
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = info[0];

                if (command == "Report")
                {
                    writer.WriteLine(managerController.Report());
                }
                else
                {
                    string infoPieceOne = info[1];
                    string infoPieceTwo = info[2];

                    if (command == "AddPlayer")
                    {
                        try
                        {
                            writer.WriteLine(managerController.AddPlayer(infoPieceOne, infoPieceTwo));
                        }
                        catch (Exception ex)
                        {
                            writer.WriteLine(ex.Message);
                        }
                    }
                    else if (command == "AddCard")
                    {
                        try
                        {
                            writer.WriteLine(managerController.AddCard(infoPieceOne, infoPieceTwo));
                        }
                        catch (Exception ex)
                        {
                            writer.WriteLine(ex.Message);
                        }
                    }
                    else if (command == "AddPlayerCard")
                    {
                        try
                        {
                            writer.WriteLine(managerController.AddPlayerCard(infoPieceOne, infoPieceTwo));
                        }
                        catch (Exception ex)
                        {
                            writer.WriteLine(ex.Message);
                        }
                    }
                    else if (command == "Fight")
                    {
                        try
                        {
                            writer.WriteLine(managerController.Fight(infoPieceOne, infoPieceTwo));
                        }
                        catch (Exception ex)
                        {
                            writer.WriteLine(ex.Message);
                        }
                    }
                }

                rawInput = reader.ReadLine();
            }
        }
    }
}
