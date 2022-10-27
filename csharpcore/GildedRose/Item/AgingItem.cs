using System;
using System.Collections.Generic;

namespace GildedRoseKata
{

    public class AgingItem : Item{

        public AgingItem(string Name, int sellIn, int Quality) 
        : base(Name, sellIn, Quality)
        {

        }
        public override void update()
        {
            throw new NotImplementedException();
        }

    }

}