using System;
using System.Collections.Generic;

namespace GildedRoseKata{
    public class InMemoryItemsRepository : ItemRepository
    {
        public InMemoryItemsRepository(List<Item> item) 
        : base(item)
        {}


    }
}