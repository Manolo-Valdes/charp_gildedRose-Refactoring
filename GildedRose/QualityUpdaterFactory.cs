
using GildedRoseKata.Contracts;

namespace GildedRoseKata
{
    public class QualityUpdaterFactory : IQualityUpdaterFactory
    {
        public const string BackstagePasses = "Backstage passes to a TAFKAL80ETC concert";
        public const string Sulfuras = "Sulfuras, Hand of Ragnaros";
        public const string AgedBrie = "Aged Brie";

        public IQualityUpdater GetQualityUpdater(Item item)
        {
            switch (item.Name)
            {
                case BackstagePasses:
                    return new BackstagePassesQualityUpdater();
                case Sulfuras:
                    return new SulfurasQualityUpdater();
                case AgedBrie:
                    return new AgedBrieQualityUpdater();
                default:
                    return new DefaultQualityUpdater();
            }
        }
    }
}
