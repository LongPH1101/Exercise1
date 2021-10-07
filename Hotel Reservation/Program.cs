
using System;

namespace LAB_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Season.Spring:" + Season.Spring);
            //Console.WriteLine("Convert.ToInt32(Season.Spring): " + Convert.ToInt32(Season.Spring));

            Console.Write("Enter info: ");
            string strInfo = Console.ReadLine();
            

            string[] splitInfo = strInfo.Split(" ");

            double total = PriceCalculator.Calculate(Convert.ToDouble(splitInfo[0]), Convert.ToInt32(splitInfo[1]), splitInfo[2], splitInfo[3]);
            
            Console.WriteLine($"Total: {total}");
        }
    }
}
