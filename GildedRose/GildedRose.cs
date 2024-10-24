using GildedRoseKata.Contracts;
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
            // use a local variable for the item
            Item item = Items[i];
            var updater = qualityUpdaterFactory.GetQualityUpdater(item);
            updater.UpdateQuality(item);
        }
    }
}