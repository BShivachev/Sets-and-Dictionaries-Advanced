using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads some text from the console and counts the occurrences of each character in it.Print the results in alphabetical(lexicographical) order.


            string someText = Console.ReadLine();
            char [] arr = someText.ToCharArray();
            var dictionary = new SortedDictionary<char, int>();
            int charLenght=arr.Length;
            for (int i = 0; i < charLenght; i++)
            {
                if (!dictionary.ContainsKey(arr[i]))
                    dictionary.Add(arr[i], 1);
                else
                    dictionary[arr[i]]++;
            }
            foreach (var ch in dictionary)
            {
                Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
            }

        }
    }
}
