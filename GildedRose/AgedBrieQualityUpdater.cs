namespace GildedRoseKata
{
    internal class AgedBrieQualityUpdater : Contracts.IQualityUpdater
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.IncreaseQuality();
            }

            item.DecreaseSellIn();
            if (item.SellIn < 0)
            {
                if (item.Quality < 50)
                {
                    item.IncreaseQuality();
                }
            }
        }
    }
}
