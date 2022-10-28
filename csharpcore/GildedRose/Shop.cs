using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class Shop
    {
        public List<Item> Items{get;set;}

        public Shop(List<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach(Item item in this.Items){
                item.update();
            }
        }
        
    }
}