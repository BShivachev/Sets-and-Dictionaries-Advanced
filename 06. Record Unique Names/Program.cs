using System;
using System.Collections.Generic;

namespace _06._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program, which will take a list of names and print only the unique names in the list.

            var set=new HashSet<string>();
            int numberOfNames = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfNames; i++)
            {
                set.Add(Console.ReadLine());
            }
            Console.WriteLine(string.Join("\n",set));
        }
    }
}
