using GildedRoseKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GildedRose
{
    [TestClass]
    public class ShopTests
    {
        public Shop shop;
        private List<Item> itemList = new List<Item>(){
            new GenericItem("Classic", 10, 8),
            new GenericItem("Classic", -1, 8),
            new GenericItem("Classic", -1, 1),
            new AgingItem("Aged Brie", 5, 4),
            new AgingItem("Aged Brie", 5, 50),
            new LegendaryItem("Sulfuras", 5, 80),
            new EventItem("Backstage Pass", 15, 10),
            new EventItem("Backstage Pass", 10, 10),
            new EventItem("Backstage Pass", 5, 10),
            new EventItem("Backstage Pass", 0, 10)
        };

        [TestInitialize]
        public void Setup(){
            this.shop = new Shop(itemList);
            this.shop.UpdateQuality();
        }

        [TestMethod]
        public void Should_UpdateItemProperties(){
            Assert.AreEqual(9, this.shop.Items[0].sellIn);
            Assert.AreEqual(7, this.shop.Items[0].Quality);
        }

        [TestMethod]
        public void Should_DecreaseQualityTwiceAsFastAfterExpiration(){
            Assert.AreEqual(6, this.shop.Items[1].Quality);
        }

        [TestMethod]
        public void Should_NotHaveNegativeQuality(){
            Assert.AreEqual(0, this.shop.Items[2].Quality);
        }

        [TestMethod]
        public void Should_IncreaseAgedBrieQuality(){
            Assert.AreEqual(5, this.shop.Items[3].Quality);
        }

        [TestMethod]
        public void Should_NotIncreaseQualityOverFifty(){
            Assert.AreEqual(50, this.shop.Items[4].Quality);
        }

        [TestMethod]
        public void Should_NotUpdateLegendaryItemProperties(){
            Assert.AreEqual(5, this.shop.Items[5].sellIn);
            Assert.AreEqual(80, this.shop.Items[5].Quality);
        }

        [TestMethod]
        public void Should_IncreaseBackstagePassQuality(){
            Assert.AreEqual(11, this.shop.Items[6].Quality);
        }

        [TestMethod]
        public void Should_IncreaseBackstagePassQualityByTwoTenDaysBefore(){
            Assert.AreEqual(12, this.shop.Items[7].Quality);
        }

        [TestMethod]
        public void Should_IncreaseBackstagePassQualityByThreeFiveDaysBefore(){
            Assert.AreEqual(13, this.shop.Items[8].Quality);
        }

        [TestMethod]
        public void Should_SetBackstagePassQualityToZeroAfterEvent(){
            Assert.AreEqual(0, this.shop.Items[9].Quality);
        }

        [TestMethod]
        public void Should_DecreaseConjuredItemsTwiceAsFastAsGenericItems(){
            Assert.AreEqual(6, this.shop.Items[10].Quality);
        }
    }
}