using GildedRoseKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GildedRoseTests
{
    [TestClass]
    public class GildedRoseTest
    {
        
        private Shop shop;

        public IList<Item> Items = new List<Item>(){
            new GenericItem("Wand", 9,8),
            new GenericItem("Sword", -1,8),
            new GenericItem("Shield", -1,1),
            new AgingItem("Aged Brie", 5, 4),
            new AgingItem("Aged Brie", 5, 50 ),
            new LegendaryItem("Sulfuras", 5,80),
            new EventItem("Backstage Pass", 15,10),
            new EventItem("Backstage Pass", 10,10),
            new EventItem("Backstage Pass", 5,10),
            new EventItem("Backstage Pass", 0,10),
            
        };

        [TestInitialize]
        public void Setup()
        {
           this.shop = new Shop(this.Items);
           this.shop.UpdateQuality();
        }

        [TestMethod]
        public void Should_UpdateItemProperties()
        {
        //    Assert.AreEqual(50, this.shop.Items[0].Quality);
        //    Assert.AreEqual(7, this.shop.Items[0].sellIn);
           Assert.AreEqual(8, this.shop.Items[0].sellIn);
           Assert.AreEqual(7, this.shop.Items[0].Quality);
        }


    }
}