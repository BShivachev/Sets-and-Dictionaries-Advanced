using System;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads continents, countries and their cities put them in a nested dictionary and prints them.
            int numberOfAdding=int.Parse(Console.ReadLine());
            var continents = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < numberOfAdding; i++)
            {
                string[] info=Console.ReadLine().Split();
                string continent=info[0];
                string country=info[1];
                string city=info[2];
                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                    
                }
                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country, new List<string>());
                }
                continents[continent][country].Add(city);
               
            }
            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var countryAndCity in continent.Value)
                {
                    Console.WriteLine($"{countryAndCity.Key} -> {string.Join(", ",countryAndCity.Value)}");
                }
            }
        }
    }
}
