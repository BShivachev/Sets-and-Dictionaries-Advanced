using System;
using System.Collections.Generic;
using System.Text;

namespace exs06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that helps you decide what clothes to wear from your wardrobe. You will receive the clothes, which are currently in your wardrobe, sorted by their color in the following format: 

            //            "{color} -> {item1},{item2},{item3}…"

            //If you receive a certain color, which already exists in your wardrobe, just add the clothes to its records. You can also receive repeating items for a certain color and you have to keep their count.

            //In the end, you will receive a color and a piece of clothing, which you will look for in the wardrobe, separated by a space in the following format: 

            //"{color} {clothing}"

            //Your task is to print all the items and their count for each color in the following format:  

            int numberOfArtcs = int.Parse(Console.ReadLine());
            var dictOfWardrop = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < numberOfArtcs; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string colour = input[0];
                var clothes = new List<string>(input[1].Split(','));
                if (!dictOfWardrop.ContainsKey(colour))
                    dictOfWardrop.Add(colour, new Dictionary<string, int>());
                foreach (var item in clothes)
                {
                    if (!dictOfWardrop[colour].ContainsKey(item))
                        dictOfWardrop[colour].Add(item, 1);
                    else
                        dictOfWardrop[colour][item]++;
                }
            }
            string[] demand = Console.ReadLine().Split();
            string ColourWanted = demand[0];
            string clotheWanted = demand[1];
            foreach (var colourEct in dictOfWardrop)
            {
                Console.WriteLine($"{colourEct.Key} clothes:");
                foreach (var clothesEct in colourEct.Value)
                {
                    var output = new StringBuilder();
                    output.Append($"* {clothesEct.Key} - {clothesEct.Value}");
                    if (colourEct.Key.Equals(ColourWanted) && clothesEct.Key.Equals(clotheWanted))
                    {
                        output.Append(" (found!)");
                    }
                    Console.WriteLine(output.ToString());
                }
            }

        }
    }
}
