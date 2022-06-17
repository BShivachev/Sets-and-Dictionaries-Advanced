using System;
using System.Collections.Generic;

namespace Exs01._Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads from the console a sequence of N usernames and keeps a collection only of the unique ones. On the first line, you will be given an integer N. On the next N lines, you will receive one username per line. Print the collection on the console in order of insertion: 

            int N = int.Parse(Console.ReadLine());
            var setOfNames = new HashSet<string>();
            while(N > 0)
            {
                string name = Console.ReadLine();
                setOfNames.Add(name);
                N--;
            }
            Console.WriteLine(string.Join("\n",setOfNames));
        }
    }
}
