namespace GildedRoseKata;

static class Extentions
{
    public static void IncreaseQuality(this Item item)
    {
        item.Quality += 1;
    }

    public static void DecreaseQuality(this Item item)
    {
        item.Quality -= 1;
    }

    public static void DropQuality(this Item item)
    {
        item.Quality = 0;
    }
}