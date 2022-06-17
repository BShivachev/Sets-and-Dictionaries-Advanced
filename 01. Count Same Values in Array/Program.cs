using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
                    //Count Same Values in Array

         //Create a program that counts in a given array of double values the number of occurrences of each value.



            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> output = new Dictionary<double, int>();
            foreach (double i in input)
            {
                if (!output.ContainsKey(i))

                    output.Add(i, 1);
                else
                    output[i]++;
            }
            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }

        }
    }
}
