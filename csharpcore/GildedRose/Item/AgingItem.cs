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
            this.UpdateSellIn();
            this.UpdateQuality();
        }

        private void UpdateSellIn(){
            this.sellIn--;
            if(this.sellIn < 0)
                this.Quality--;
        }

        private void UpdateQuality(){
            this.Quality++;

            FloorQualityToZero();
            CeilQualityToFifty();
        }
    }

}