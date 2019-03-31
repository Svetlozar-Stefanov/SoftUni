using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "end")
                {
                    break;
                }

                string serialNumber = command[0];
                string itemName = command[1];
                int itemQuantity = int.Parse(command[2]);
                decimal itemPrice = decimal.Parse(command[3]);

                Box box = new Box();
                box.SerialNumber = serialNumber;
                box.Item.Name = itemName;
                box.ItemQuantity = itemQuantity;
                box.Item.Price = itemPrice;
                box.PriceForABox = itemQuantity * itemPrice;

                boxes.Add(box);
            }

            boxes = boxes.OrderByDescending(x => x.PriceForABox).ToList();

            foreach (var box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }
        }
    }

    class Item
    {
        public string Name;
        public decimal Price;
    }

    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public string SerialNumber;
        public Item Item;
        public int ItemQuantity;
        public decimal PriceForABox;
    }
}
