using System;
using System.Collections.Generic;

namespace GildedRoseKata
{

    public class GenericItem : Item{

        public GenericItem(string Name, int sellIn, int Quality) 
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
            this.sellIn--;
            if(this.sellIn < 0)
                this.Quality--;
                        
            FloorQualityToZero();
            CeilQualityToFifty();
        }

    }

}