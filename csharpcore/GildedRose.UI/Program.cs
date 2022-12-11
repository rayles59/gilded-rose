using System;
using System.Collections.Generic;
using GildedRoseKata;
using System.Net.Mail;
using System.Net;

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
                    shop.showArticle(repository);
                    break;
                // Afficher les soldes du magasins
                case "2":
                    Console.WriteLine("Le total du magasin est de : " + shop.SoldMagasin(repository.GetInventory(), shop));
                    break;
                // vendre un article
                case "3":
                    var item = repository.FindItem("Classic", 8);
                    shop.sellItem(item, items);
                    shop.showArticle(repository);
                    break;
                case "4":
                    //met à jour la qualité
                    shop.UpdateQuality();
                    shop.showArticle(repository);
                    break;
                case "5":
                    //lance une vente au enchère
                    shop.StartAuction(shop, repository);
                    break;
                case "6":
                    break;
            }
            Console.WriteLine("Appuyer sur entrer");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("taper 1 pour afficher les articles");
            Console.WriteLine("taper 2 pour afficher le solde du magasin ");
            Console.WriteLine("taper 3 pour vendre un article");
            Console.WriteLine("taper 4 pour update les items");
            Console.WriteLine("taper 5 pour commencer la vente au enchère");

            var action = Console.ReadLine();
            if (action != string.Empty)
                p.ChooseActionShop(action);
            Console.ReadKey();


        }


    }
}