using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            var studentGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] data = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                string name = data[0];
                double grade = double.Parse(data[1]);

                if (studentGrades.ContainsKey(name))
                {
                    studentGrades[name].Add(grade);
                }
                else
                {
                    studentGrades.Add(name, new List<double>() { grade });
                }
            }

            foreach (var student in studentGrades)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
                
        }
    }
}
