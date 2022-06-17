using System;
using System.Collections.Generic;
using System.Linq;

namespace exs07._The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that keeps the information about v-loggers and their followers. The input will come as a sequence of strings, where each string will represent a valid command. The commands will be presented in the following format: 

            var userInfo = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            int count = 0;

            string input = Console.ReadLine();
            while (input != "Statistics")
            {
                string vlogerName = input.Split(' ')[0];
                if (input.Contains("joined"))
                {
                    if (!userInfo.ContainsKey(vlogerName))
                    {
                        count++;
                        userInfo.Add(vlogerName, new Dictionary<string, HashSet<string>>());
                        userInfo[vlogerName].Add("followers", new HashSet<string>());
                        userInfo[vlogerName].Add("following", new HashSet<string>());
                    }
                }
                else
                {
                    string secondVloger = input.Split(' ')[2];
                    if (vlogerName != secondVloger && userInfo.ContainsKey(vlogerName) && userInfo.ContainsKey(secondVloger))
                    {
                        userInfo[vlogerName]["following"].Add(secondVloger);
                        userInfo[secondVloger]["followers"].Add(vlogerName);
                    }

                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"The V-Logger has a total of {count} vloggers in its logs.");
            int number = 1;
            foreach (var vlogger in userInfo.OrderByDescending(v => v.Value["followers"].Count).ThenBy(v => v.Value["following"].Count))
            {
                Console.WriteLine($"{number}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");

                if (number == 1)
                {
                    foreach (string follower in vlogger.Value["followers"].OrderBy(f => f))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                number++;
            }
        }
    }
}
