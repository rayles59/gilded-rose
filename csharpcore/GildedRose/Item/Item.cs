using System;

namespace GildedRoseKata
{
   public abstract class Item
    {

        public string Name {get;protected set;}
        public int sellIn{get;protected set;}
        public int Quality{get;protected set;}

        public Item (string Name, int sellIn, int Quality){
            this.Name = Name;
            this.sellIn = sellIn;
            this.Quality = Quality;
        }

        public abstract void update();

        protected void FloorQualityToZero()
        {
            if(this.Quality < 0)
                this.Quality = 0;
        }

        protected void CeilQualityToFifty()
        {
            if(this.Quality < 50)
                this.Quality = 50;
        }

    }
}