using System.Collections.Generic;
using GildedRoseKata;
using GildedRoseKata.Core;
using NUnit.Framework;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Test]
    [TestCase("foo", 0, 0, -1 , 0)]
    [TestCase("foo", 0, 5, -1, 3)]
    [TestCase(QualityUpdaterFactory.AgedBrie, 0, 0, -1, 2)]
    [TestCase(QualityUpdaterFactory.AgedBrie, 2, 0, 1, 1)]
    [TestCase(QualityUpdaterFactory.BackstagePasses, 0, 5, -1, 0)]
    [TestCase(QualityUpdaterFactory.BackstagePasses, 1, 5, 0, 8)]
    [TestCase(QualityUpdaterFactory.BackstagePasses, 6, 5, 5, 7)]
    [TestCase(QualityUpdaterFactory.Sulfuras, 0, 5, 0, 5)]
    [TestCase(QualityUpdaterFactory.Sulfuras, -1, 5, -1, 5)]
    public void Foo(string name, int sellIn, int quality , int sellInOut, int qualityOut)
    {
        var items = new List<Item> { new Item { Name = name, SellIn = sellIn, Quality = quality } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Item item = items[0];
        Assert.That(item.SellIn, Is.EqualTo(sellInOut));
        Assert.That(item.Quality, Is.EqualTo(qualityOut));
    }


}