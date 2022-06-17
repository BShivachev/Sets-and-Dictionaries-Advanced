using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //There is a party in SoftUni. Many guests are invited and there are two types of them: VIP and Regular. When a guest comes, check if he/she exists in any of the two reservation lists.
            //All reservation numbers will be with the length of 8 chars.
            //All VIP numbers start with a digit. 
            //First, you will be receiving the reservation numbers of the guests. You can also receive 2 possible commands: 
            //*"PARTY" – After this command, you will begin receiving the reservation numbers of the people, who came to the party. 
            //"END" – The party is over and you have to stop the program and print the appropriate output. 
            //In the end, print the count of the guests who didn't come to the party, and afterward, print their reservation numbers. the VIP guests must be first. 
            var input = Console.ReadLine();
            var allReservations = new HashSet<string>();
            int arrivedGuest = 0;
            while (input != "PARTY")
            {
                if (input.Length == 8)
                {

                    allReservations.Add(input);
                }
                input = Console.ReadLine();
            }
            while (allReservations.Count != 0)
            {
                string arrivedGuests = Console.ReadLine();
                if (!arrivedGuests.Equals("END"))
                {
                    allReservations.Remove(arrivedGuests);
                    arrivedGuest++;
                }
                else
                    break;
            }
            int count = allReservations.Count;
            Console.WriteLine(count);
            Console.WriteLine(string.Join("\n", allReservations));
        }
    }
}
