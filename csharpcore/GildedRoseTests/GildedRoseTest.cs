using GildedRoseKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GildedRoseTests
{
    [TestClass]
    public class GildedRoseTest
    {
        [TestMethod]
        public void Should_Build()
        {
            Article a = new Article();
            GildedRose shop = new GildedRose(a);
            // Assert.AreEqual("c", shop.test);
        }
    }
}