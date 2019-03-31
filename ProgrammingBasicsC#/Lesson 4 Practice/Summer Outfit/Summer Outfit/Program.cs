using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature = int.Parse(Console.ReadLine());
            string timeOfTheDay = Console.ReadLine();

            

            if (timeOfTheDay == "Morning")
            {
                if (temperature >= 10 && temperature <= 18)
                {
                   
                    Console.WriteLine($"It's {temperature} degrees, get your Sweatshirt and Sneakers.");

                }

                else if (temperature > 18 && temperature <= 24)
                {
                    
                    Console.WriteLine($"It's {temperature} degrees, get your Shirt and Moccasins.");

                }

                else if (temperature >= 25)
                {
                   
                    Console.WriteLine($"It's {temperature} degrees, get your T-Shirt and Sandals.");
                }

                

            }

            else if (timeOfTheDay == "Afternoon")
            {
                if (temperature >= 10 && temperature <= 18)
                {
                  
                    Console.WriteLine($"It's {temperature} degrees, get your Shirt and Moccasins.");
                }

                else if (temperature > 18 && temperature <= 24)
                {
                    
                    Console.WriteLine($"It's {temperature} degrees, get your T-Shirt and Sandals.");
                }

                else if (temperature >= 25)
                {
                    
                    Console.WriteLine($"It's {temperature} degrees, get your Swim Suit and Barefoot.");
                }
                
            }

            else if (timeOfTheDay == "Evening")
            {
                if (temperature >= 10 && temperature <= 18)
                {
                    Console.WriteLine($"It's {temperature} degrees, get your Shirt and Moccasins.");
                }

                else if (temperature > 18 && temperature <= 24)
                {
                    Console.WriteLine($"It's {temperature} degrees, get your Shirt and Moccasins.");
                }

                else if (temperature >= 25)
                {
                    Console.WriteLine($"It's {temperature} degrees, get your Shirt and Moccasins.");

                }
                
            }

           
        }
    }
}
