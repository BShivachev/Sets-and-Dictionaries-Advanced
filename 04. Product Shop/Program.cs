using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that prints information about food shops in Sofia and the products they store. Until the "Revision" command is received, you will be receiving input in the format: "{shop}, {product}, {price}".Keep in mind that if you receive a shop you already have received, you must collect its product information.
            
            var shop=new Dictionary<string,Dictionary<string,double>>();
            string input =Console.ReadLine();
            while (!input.Equals("Revision"))
            {
                string shopName = input.Split(", ")[0];
                string product = input.Split(", ")[1];
                double price = double.Parse(input.Split(", ")[2]);
                if (!shop.ContainsKey(shopName))
                {
                    shop.Add(shopName, new Dictionary<string, double>());

                }
                shop[shopName].Add(product, price);
                input = Console.ReadLine();
            }
            shop=shop.OrderBy(x=>x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var shopName in shop)
            {
                Console.WriteLine($"{shopName.Key}->");
                foreach (var item in shopName.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }

        }
    }
}
