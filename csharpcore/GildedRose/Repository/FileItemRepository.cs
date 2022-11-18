using System;
using System.Collections.Generic;

namespace GildedRoseKata{
    public class FileItemRepository : ItemRepository
    {
        private List<Item> items = new List<Item>(){
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