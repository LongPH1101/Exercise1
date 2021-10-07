using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    class PriceCalculator
    {
        public static double Calculate(double price, int numDay, string season, string dis)
        {
            double total = 0;

            total = price * numDay;

            if (season == "Autumn")
                total = total * Convert.ToInt32(Season.Autumn);
            if (season == "Spring")
                total = total * Convert.ToInt32(Season.Spring);
            if (season == "Winter")
                total = total * Convert.ToInt32(Season.Winter);
            if (season == "Summer")
                total = total * Convert.ToInt32(Season.Summer);

            double discount = 0;

            if (dis == "None")
                discount = total * 1;
            if (dis == "VIP")
                discount = total * Convert.ToInt32(Discount.VIP) / 100;
            if (dis == "SecondVisit")
                discount = total * Convert.ToInt32(Discount.SecondVisit) / 100;

            total = total - discount;
            
                return total;
        }
    }
}
