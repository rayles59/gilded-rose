using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public interface ItemRepository
    {
        List<Item> GetInventory();
        void SaveInventory(List<Item> item);
        Item FindItem(string type, int quality);
    }
}