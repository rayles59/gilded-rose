using System;
using System.Collections.Generic;

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
                return sellIn;
            }
            
            return sellIn + valueAuction;
        }
    }
}