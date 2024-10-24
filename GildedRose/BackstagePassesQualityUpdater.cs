namespace GildedRoseKata
{
    internal class BackstagePassesQualityUpdater : Contracts.IQualityUpdater
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.IncreaseQuality();

                if (item.Quality < 50)
                {
                    if (item.SellIn < 11)
                    {
                        item.IncreaseQuality();
                    }

                    if (item.SellIn < 6)
                    {
                        item.IncreaseQuality();
                    }
                }
            }
            item.SellIn = item.SellIn - 1;
            if (item.SellIn < 0)
            {
                item.DropQuality();
            }
        }
    }
}
