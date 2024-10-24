namespace GildedRoseKata.Contracts
{
    public interface IQualityUpdaterFactory
    {
        IQualityUpdater GetQualityUpdater(Item item);
    }
}