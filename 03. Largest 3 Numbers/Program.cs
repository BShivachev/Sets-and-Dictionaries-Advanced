using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Largest 3 Numbers

            //Read a list of integers and print the largest 3 of them. If there are less than 3, print all of them.

            //Read an array of integers.
           //Order the array using a LINQ query.
          //Print top 3 numbers with a for loop.


            List<int> numbers = new List<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            numbers.OrderByDescending(x=>x).ToList();
            var output= numbers.OrderByDescending(x => x).ToList().Take(3);
            Console.WriteLine(string.Join(" ",output));
        }
    }
}
