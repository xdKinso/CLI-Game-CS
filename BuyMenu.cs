using System;
using System.Collections.Generic;

namespace MyGame
{
    public class BuyMenu
    {
        private List<Item> items;

        public BuyMenu()
        {
            items = new List<Item>{
                new Item("Sword", 10, 0, 5),
                new Item("Shield", 5, 5 , 0),
                new Item("Helmet",10, 5, 0),
                new Item("ChestPlate", 15, 10, 0),
                new Item("Leggings", 10, 5, 0),
                new Item("Boots", 5, 5, 0),
            };
        }

        public void DisplayBuyMenu()
        {
            Console.WriteLine("Welcome to the Buy Menu!");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Name} - {item.Attack} ATK - {item.Defense} DEF - {item.Price} Gold");
            }
        }
    }
}