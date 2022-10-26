using System;

namespace GildedRoseKata
{
    public class GildedRose
    {
        private Article article;

        public GildedRose(Article article){
            this.article = article;
        }

        public void endDay(){
            try{

                this.article.quality = this.updateQuality(this.article.sellIn,this.article.quality,this.article.peremption);

            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }

        public int updateQuality(TimeSpan valueSellIn, int quality, TimeSpan peremption){
    
            if(quality < 0){
                return quality;
            }

            checkQuality(valueSellIn, quality, peremption);
            checkNameQuality(this.article.name, this.article.quality, this.article.sellIn);

            return quality;
        }

        public void checkQuality(TimeSpan valueSellIn, int quality, TimeSpan peremption)
        {
            valueSellIn = valueSellIn - peremption;
            if(valueSellIn.Days < 0){
                quality = quality -2;
            }else{
                quality--;
            }
        }

        public void checkNameQuality(string name, int quality, TimeSpan sellIn){
            switch (name)
            {
                case "Aged Brie":
                    quality++;
                    break;

                case "Sulfuras":
                    
                    break;

                case "Backstage passes":
                    quality++;
                    break;
            }
        }


    }
}