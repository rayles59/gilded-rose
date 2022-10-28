using System;
using System.Collections.Generic;

namespace GildedRoseKata{
    public class FileItemRepository : ItemRepository
    {
        public FileItemRepository(List<Item> item) 
        : base(item)
        {}

        
    }
}