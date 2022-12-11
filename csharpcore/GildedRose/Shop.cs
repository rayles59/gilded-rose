using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Net;

namespace GildedRoseKata
{
    public class Shop
    {
        public List<Item> Items { get; set; }
        public double solde;

        public Shop(List<Item> Items)
        {
            this.Items = Items;
        }

        public double TotalSold(double value)
        {
            return this.solde += value;
        }

        public void UpdateQuality()
        {
            foreach (Item item in this.Items)
            {
                item.update();
            }
        }

        public void sellItem(Item item, List<Item> items)
        {
            Items.Remove(item);

        }
        public int roundAuction(int sellIn, int valueAuction)
        {
            if(valueAuction < sellIn * 0.1 ){
                Console.WriteLine("Veuillez entrer une mise supérieur à 10%");
                return sellIn;
            }
            
            return sellIn + valueAuction;
        }
        public double SoldMagasin(List<Item> items, Shop shop){
            double value = 0;
            foreach(Item i in items){
                value = shop.TotalSold(i.sellIn);
            }

            return value;
        }

        public void StartAuction(Shop shop, ItemRepository repository)
        {
            /*
               ici on pré-définit l'item, on pourrait très bien le faire choisir par l'utilisateur avec des Console.readLine()
               en le passant en paramètre de la méthode findItem
            */
            var item = repository.FindItem("Classic", 8);
            var valueFinaleOfItem = item.sellIn;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("la valeur actuelle de l'item est de : " + valueFinaleOfItem);
                Console.WriteLine("Veuillez entre votre mise");
                var amount = Convert.ToInt16(Console.ReadLine());
                var value = shop.roundAuction(valueFinaleOfItem, amount);
                valueFinaleOfItem = value;
            }
            Console.WriteLine("l'enchère gagnante est de : " + valueFinaleOfItem);
        }

        public void showArticle(ItemRepository repository)
        {
            var inventory2 = repository.GetInventory();
            foreach (var i in inventory2)
            {
                Console.WriteLine(i.Name + " " + i.Quality + " " + i.sellIn);
            }
        }

    }
}