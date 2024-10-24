namespace GildedRoseKata
{
    internal class DefaultQualityUpdater : Contracts.IQualityUpdater
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.DecreaseQuality();
            }
            item.SellIn = item.SellIn - 1;
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
