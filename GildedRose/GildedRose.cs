using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    // Use const string and remove duplications of them
    private const string B_To_TAK = "Backstage passes to a TAFKAL80ETC concert";
    private const string Sul_H = "Sulfuras, Hand of Ragnaros";
    private const string Aged_B = "Aged Brie";

    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        for (var i = 0; i < Items.Count; i++)
        {
            // use a local var reference
            Item item = Items[i];

            if (item.Name != Aged_B && item.Name != B_To_TAK)
            {
                if (item.Quality > 0)
                {
                    if (item.Name != Sul_H)
                    {
                        item.Quality = item.Quality - 1;
                    }
                }
            }
            else
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;

                    if (item.Name == B_To_TAK)
                    {
                        if (item.SellIn < 11)
                        {
                            if (item.Quality < 50)
                            {
                                item.Quality = item.Quality + 1;
                            }
                        }

                        if (item.SellIn < 6)
                        {
                            if (item.Quality < 50)
                            {
                                item.Quality = item.Quality + 1;
                            }
                        }
                    }
                }
            }

            if (item.Name != Sul_H)
            {
                item.SellIn = item.SellIn - 1;
            }

            if (item.SellIn < 0)
            {
                if (item.Name != Aged_B)
                {
                    if (item.Name != B_To_TAK)
                    {
                        if (item.Quality > 0)
                        {
                            if (item.Name != Sul_H)
                            {
                                item.Quality = item.Quality - 1;
                            }
                        }
                    }
                    else
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                }
                else
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            }
        }
    }
}