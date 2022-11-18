using System;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseKata
{
    class Program
    {
        public void ChooseActionShop(string action)
        {
            List<Item> items = new List<Item>(){
                new GenericItem("Classic", 10, 8),
                new GenericItem("Classic", -1, 8),
                new GenericItem("Classic", -1, 1),
                new AgingItem("Aged Brie", 5, 4),
                new AgingItem("Aged Brie", 5, 50),
                new LegendaryItem("Sulfuras", 5, 80),
                new EventItem("Backstage Pass", 15, 10),
                new EventItem("Backstage Pass", 10, 10),
                new EventItem("Backstage Pass", 5, 10),
                new EventItem("Backstage Pass", 0, 10)
            };
            ItemRepository repository = new FileItemRepository(items);
            Shop shop = new Shop(items);
            switch (action)
            {
                //Afficher les articles
                case "1":                    
                    var inventory = repository.GetInventory();
                    foreach(var i in inventory){
                        Console.WriteLine(i.Name +" "+ i.Quality +" "+ i.sellIn);
                    }
                    break;
                // Afficher les soldes du magasins
                case "2":
                    break;
                // vendre un article
                case "3":
                    var item = repository.FindItem("Classic", 8);
                    Console.WriteLine(item.Name +" "+ item.Quality +" "+ item.sellIn);
                    shop.sellItem(item, items);
                    Console.WriteLine(items.Count);
                    break;
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("taper 1 pour afficher les articles");
            Console.WriteLine("taper 2 pour afficher le solde du magasin ");
            Console.WriteLine("taper 3 pour vendre un article"); 
            var action = Console.ReadLine();
            if(action != string.Empty)
                p.ChooseActionShop(action);
            Console.ReadKey();
        }
    }
}