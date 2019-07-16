using MilitaryElite.Models;
using MilitaryElite.Soldiers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
    public static class Engine
    {
        private static List<Private> privates = new List<Private>();

        public static void Run()
        {
            string[] input = Console.ReadLine()
                .Split();

            while (input[0].ToLower() != "end")
            {
                string rank = input[0];
                string id = input[1];
                string firstName = input[2];
                string lastName = input[3];

                if (rank == "Private")
                {
                    decimal salary = decimal.Parse(input[4]);

                    Private privateSoldier = new Private(id, firstName, lastName, salary);

                    privates.Add(privateSoldier);

                    Console.WriteLine(privateSoldier);
                }
                else if (rank == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(input[4]);
                    LieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);

                    for (int i = 5; i < input.Length; i++)
                    {
                        string privateId = input[i];

                        lieutenantGeneral.Privates.Add(privates.FirstOrDefault(p => p.Id == privateId));
                    }

                    Console.WriteLine(lieutenantGeneral);
                }
                else if (rank == "Engineer")
                {
                    decimal salary = decimal.Parse(input[4]);
                    string corp = input[5];
                    try
                    {
                        Engineer engineer = new Engineer(id, firstName, lastName, salary, corp);
                        for (int i = 6; i < input.Length - 1; i+=2)
                        {
                            string part = input[i];
                            int hours = int.Parse(input[i + 1]);

                            Repair repair = new Repair(part, hours);
                            engineer.Repairs.Add(repair);
                        }
                        Console.WriteLine(engineer);
                    }
                    catch (Exception)
                    {
                        input = Console.ReadLine()
                        .Split();
                        continue;
                    }
                }
                else if (rank == "Commando")
                {
                    decimal salary = decimal.Parse(input[4]);
                    string corp = input[5];
                    Commando commando = null;
                    try
                    {
                        commando = new Commando(id, firstName, lastName, salary, corp);
                    }
                    catch (Exception)
                    { 
                        continue;
                    }

                    for (int i = 6; i < input.Length - 1; i+=2)
                    {
                        string name = input[i];
                        string status = input[i + 1];

                        try
                        {
                            Mission mission = new Mission(name, status);
                            commando.Missions.Add(mission);
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }

                    Console.WriteLine(commando);
                }

                else if (rank == "Spy")
                {
                    int codeNumber = int.Parse(input[4]);
                    Spy spy = new Spy(id, firstName, lastName, codeNumber);
                    Console.WriteLine(spy);
                }

                input = Console.ReadLine()
                .Split();
            }
        }
    }
}
