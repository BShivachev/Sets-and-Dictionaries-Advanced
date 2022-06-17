using System;
using System.Collections.Generic;
using System.Linq;

namespace exs02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that prints a set of elements. On the first line, you will receive two numbers - n and m, which represent the lengths of two separate sets. On the next n + m lines, you will receive n numbers, which are the numbers in the first set, and m numbers, which are in the second set. Find all the unique elements that appear in both of them and print them in the order in which they appear in the first set - n. 


            int[] numbers=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n=numbers[0];
            int m=numbers[1];
            var nSet=new HashSet<int>();
            var mSet=new HashSet<int>();
            for (int i = 0; i < n+m; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (i<n)
                {

                    nSet.Add(input);
                }
                else
                {
                    mSet.Add(input);
                }
            }
            //var newList=new List<int>();
            //foreach (int num in nSet)
            //{
            //    if (mSet.Contains(num))
            //    {
            //        newList.Add(num);
            //    }
            //}
            //Console.WriteLine(string.Join(" ",newList));
            nSet.IntersectWith(mSet);
            Console.WriteLine(string.Join(" ",nSet));
        }
    }
}
