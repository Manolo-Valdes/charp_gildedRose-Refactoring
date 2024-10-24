using GildedRoseKata.Contracts;
using GildedRoseKata.Core;
using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;

    private readonly IQualityUpdaterFactory qualityUpdaterFactory;
    public GildedRose(IList<Item> Items)
    {
        qualityUpdaterFactory = new QualityUpdaterFactory();
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        for (var i = 0; i < Items.Count; i++)
        {
            Item item = Items[i];
            var updater = qualityUpdaterFactory.GetQualityUpdater(item);
            updater.UpdateQuality(item);
        }
    }
}