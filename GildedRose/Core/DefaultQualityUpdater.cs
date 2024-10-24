﻿namespace GildedRoseKata.Core
{
    internal class DefaultQualityUpdater : Contracts.IQualityUpdater
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.DecreaseQuality();
            }
            item.DecreaseSellIn();
            if (item.SellIn < 0)
            {
                if (item.Quality > 0)
                {
                    item.DecreaseQuality();
                }
            }
        }
    }
}
