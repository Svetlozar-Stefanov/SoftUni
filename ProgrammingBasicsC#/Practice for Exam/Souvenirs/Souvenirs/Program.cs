using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Souvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string typeSouvenir = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double total = 0;

            if (team == "Argentina" || team == "Brazil" || team == "Croatia" || team == "Denmark" )
            {
                if (typeSouvenir == "flags" || typeSouvenir == "caps" || typeSouvenir == "posters" || typeSouvenir == "stickers")
                {
                    if (team == "Argentina")
                    {
                        if (typeSouvenir == "flags")
                        {
                            total += 3.25 * quantity;
                        }
                        if (typeSouvenir == "caps")
                        {
                            total += 7.20 * quantity;
                        }
                        if (typeSouvenir == "posters")
                        {
                            total += 5.10 * quantity;
                        }
                        if (typeSouvenir == "stickers")
                        {
                            total += 1.25 * quantity;
                        }
                    }
                    if (team == "Brazil")
                    {
                        if (typeSouvenir == "flags")
                        {
                            total += 4.20 * quantity;
                        }
                        if (typeSouvenir == "caps")
                        {
                            total += 8.50 * quantity;
                        }
                        if (typeSouvenir == "posters")
                        {
                            total += 5.35 * quantity;
                        }
                        if (typeSouvenir == "stickers")
                        {
                            total += 1.20 * quantity;
                        }
                    }
                    if (team == "Croatia")
                    {
                        if (typeSouvenir == "flags")
                        {
                            total += 2.75 * quantity;
                        }
                        if (typeSouvenir == "caps")
                        {
                            total += 6.90 * quantity;
                        }
                        if (typeSouvenir == "posters")
                        {
                            total += 4.95 * quantity;
                        }
                        if (typeSouvenir == "stickers")
                        {
                            total += 1.10 * quantity;
                        }
                    }
                    if (team == "Denmark")
                    {
                        if (typeSouvenir == "flags")
                        {
                            total += 3.10 * quantity;
                        }
                        if (typeSouvenir == "caps")
                        {
                            total += 6.50 * quantity;
                        }
                        if (typeSouvenir == "posters")
                        {
                            total += 4.80 * quantity;
                        }
                        if (typeSouvenir == "stickers")
                        {
                            total += 0.90 * quantity;
                        }
                    }
                    Console.WriteLine($"Pepi bought {quantity} {typeSouvenir} of {team} for {total:f2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else
            {
                Console.WriteLine("Invalid country!");
            }
        }
    }
}
