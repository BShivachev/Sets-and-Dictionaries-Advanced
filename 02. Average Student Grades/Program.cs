using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Average Student Grades

            //Create a program, which reads a name of a student and his/ her grades and adds them to the student record, then prints the students' names with their grades and their average grade. 
            //Hints

            //  Use a dictionary(string à List<decimal>)

            //Check if the name exists before adding the grade. If it doesn't, add it to the dictionary. 

            //Pass through all key-value pairs in the dictionary and print the results. You can use the.Average() method to quickly calculate the average value from a list.
            int countOfStudents = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> record = new Dictionary<string, List<double>>();
            for (int i = 0; i < countOfStudents; i++)
            {
                string[] students = Console.ReadLine().Split(' ');
                string name = students[0];
                double grade = double.Parse(students[1]);


                if (!record.ContainsKey(name))

                    record[name] = new List<double>();
                record[name].Add(grade);
            }
            foreach (var item in record)
            {

                double averageGrade = item.Value.Average();
                var gradeList = item.Value;
                string gradesStr = string.Join(" ", gradeList.Select(x => x.ToString("f2")));

                
                Console.WriteLine($"{item.Key} -> {gradesStr} (avg: {averageGrade:f2})");
            }


        }
    }
}
