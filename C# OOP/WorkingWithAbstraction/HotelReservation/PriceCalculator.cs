using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public enum Season
    {
        Autumn = 1,
        Spring,
        Winter,
        Summer
    };
    public enum Discounts
    {
        Vip = 20,
        SecondVisit = 10,
        None = 0
    };
    public class PriceCalculator
    {
        public static decimal GetFullPrice(decimal pricePerDay, int numberOfDays, Season season, Discounts discountType)
        {
            int multiplier = (int)season;
            decimal discountMultiplier = (decimal)discountType / 100;
            decimal priceBeforeDiscount = numberOfDays * pricePerDay * multiplier;
            decimal priceWithDiscount = priceBeforeDiscount * discountMultiplier;

            return priceBeforeDiscount - priceWithDiscount;
        }
    }
}
