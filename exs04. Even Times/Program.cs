using System;
using System.Collections.Generic;
using System.Linq;

namespace exs04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that prints a number from a collection, which appears an even number of times in it. On the first line, you will be given n – the count of integers you will receive. On the next n lines, you will be receiving the numbers. It is guaranteed that only one of them appears an even number of times. Your task is to find that number and print it in the end.

            int n = int.Parse(Console.ReadLine());
            var numList = 0;
            var appearance = new Dictionary<int, int>();
            while (n > 0)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (!appearance.ContainsKey(numbers))
                    appearance[numbers] = 1;
                else
                    appearance[numbers]++;

                n--;
            }
            //Console.WriteLine(appearance
            //                    .First(entry => entry.Value % 2 == 0));
            foreach (var number in appearance)
            {
                if (number.Value % 2 == 0)

                    numList = number.Key;
            }
            Console.WriteLine(numList);

        }
    }
}
