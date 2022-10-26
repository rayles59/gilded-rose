using GildedRoseKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GildedRoseTests
{
    [TestClass]
    public class GildedRoseTest
    {
        private GildedRose gilded;
        private Article article;

        [TestInitialize]
        public void Setup()
        {
            article= new Article(){
                name = "Aged Brie",
                peremption = new System.TimeSpan(),
                quality = 0,
                sellIn = new System.TimeSpan()
            };

            this.gilded = new GildedRose(article);
        }

        [TestMethod]
        public void Should_Build()
        {
            gilded.eachDay();
           
        }

         [TestMethod]
        public void shoudl_qualityTest()
        {
            Assert.AreEqual(0, gilded.updateQuality(article.sellIn,article.quality, article.peremption));
        }

    }
}