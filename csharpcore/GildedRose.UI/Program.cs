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
                    this.SoldMagasin(repository.GetInventory(), shop);
                    break;
                // vendre un article
                case "3":
                    var item = repository.FindItem("Classic", 8);
                    shop.sellItem(item, items);
                    break;
                 case "4":
                    shop.UpdateQuality();
                    break;
            }
        }
        public void SoldMagasin(List<Item> items, Shop shop){
            foreach(Item i in items){
                shop.TotalSold(i.sellIn);
            }
            
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("taper 1 pour afficher les articles");
            Console.WriteLine("taper 2 pour afficher le solde du magasin ");
            Console.WriteLine("taper 3 pour vendre un article"); 
            Console.WriteLine("taper 4 pour update les items"); 

            var action = Console.ReadLine();
            if(action != string.Empty)
                p.ChooseActionShop(action);
            Console.ReadKey();
        }
    }
}