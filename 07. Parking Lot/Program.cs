using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that: 
            //    *Records a car number for every car that enters the parking lot.
            //    *Removes a car number when the car leaves the parking lot.

            // The input will be a string in the format: "direction, carNumber".You will be receiving commands until the "END" command is given.
            //    Print the car numbers of the cars, which are still in the parking lot:
            
            var carNumber=new HashSet<string>();
            var input = Console.ReadLine();
            while (!input.Equals("END"))
            {
                string[] inputArr = input.Split(", ");
                string direction=inputArr[0];
                string carRegNum=inputArr[1];
                if (direction=="IN")
                    carNumber.Add(carRegNum);
                else if (direction=="OUT")
                    carNumber.Remove(carRegNum); 
                input=Console.ReadLine();
            }
            if (carNumber.Count==0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                Console.WriteLine(string.Join("\n",carNumber));
            }

        }
    }
}
