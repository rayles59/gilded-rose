using System;
using System.Collections.Generic;

namespace GildedRoseKata{
    public class FileItemRepository : ItemRepository
    {
        private List<Item> items = new List<Item>(){
         
        };
        public FileItemRepository(List<Item> items)
        {
            this.items = items;
        }

        public List<Item> GetInventory()
        {
            return items;
        }

        public void SaveInventory(List<Item> item)
        {
            throw new NotImplementedException();
        }

        public Item FindItem(string type, int quality)
        {
            foreach(Item item in items){
                if(item.Quality == quality && item.Name == type){
                    return item;
                }
            }
            return null;
        }
    }
}