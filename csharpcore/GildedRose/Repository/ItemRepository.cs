using System;
using System.Collections.Generic;

namespace GildedRoseKata{
    abstract public class ItemRepository{

        private List<Item> item;
        public ItemRepository(List<Item> item){
            this.item = item;
        }
        protected List<Item> GetInventory()
        {
            return item;
        }
        protected void SaveInventory(IList<Item> item)
        {

        }  
    }
}