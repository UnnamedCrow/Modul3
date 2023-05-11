﻿namespace Unit_15_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
           {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);
            Console.WriteLine(string.Join(" ", allStudents));
            Console.ReadLine();
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            return classes[0].Students.Concat(classes[1].Students.Concat(classes[2].Students)).ToArray();
        }
    }
}