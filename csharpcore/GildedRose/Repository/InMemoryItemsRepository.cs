using System;

namespace GildedRoseKata{
    public class InMemoryItemsRepository : ItemRepository
    {
        public InMemoryItemsRepository(Item item) 
        : base(item)
        {}

        
    }
}