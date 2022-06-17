using System;
using System.Collections.Generic;
using System.Linq;

namespace exc03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that keeps all the unique chemical elements. On the first line, you will be given a number n - the count of input lines that you are going to receive. On the next n lines, you will be receiving chemical compounds, separated by a single space. Your task is to print all the unique ones in ascending order: 

            int n=int.Parse(Console.ReadLine());
            var setOfChem=new HashSet<string>();
            while (n>0)
            {
                List<string> chemicals=Console.ReadLine().Split(' ').ToList();
                foreach (var item in chemicals)
                {
                    setOfChem.Add(item);
                }
                n--;
            }
            setOfChem=setOfChem.OrderBy(x => x).ToHashSet();
            Console.WriteLine(string.Join(" ",setOfChem));
        }
    }
}
