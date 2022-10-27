using System;
using System.Collections.Generic;

namespace GildedRoseKata
{

    public class EventItem : Item{

        public EventItem(string Name, int sellIn, int Quality) 
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
        }
        private void UpdateQuality(){
            this.Quality++;
            if(this.sellIn <= 10)
                this.Quality++;
            if(this.sellIn <= 5)
                this.Quality = 0;

            if(sellIn <= 0)
                this.Quality = 0;
            
            FloorQualityToZero();
            CeilQualityToFifty();
        }

    }

}