using System;
using System.Collections.Generic;

namespace GildedRoseKata{
    abstract public class ItemRepository{

        private Item item;
        public ItemRepository(Item item){
            this.item = item;
        }
        protected Item GetInventory()
        {
            return item;
        }
        protected void SaveInventory(IList<Item> item)
        {

        }  
    }
}