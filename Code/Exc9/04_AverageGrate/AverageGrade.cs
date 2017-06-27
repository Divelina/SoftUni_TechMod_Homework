using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_AverageGrate
{
    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade
        {
            get { return Grades.Average(); }
        }
    }

    public class AverageGrade
    {
        public static void Main()
        {
            var lineNum = int.Parse(Console.ReadLine());
            var studentGrades = new List<Student>();

            for (int i = 1; i <= lineNum; i++)
            {
                var nextStudent = Console.ReadLine().Split(' ').ToList();

                var name = nextStudent[0];
                var grades = nextStudent.Skip(1).Select(double.Parse).ToList();

                var theStudent = CreateStudent(name, grades);
                studentGrades.Add(theStudent);
            }

            studentGrades = studentGrades
                .Where(s => s.AverageGrade >= 5.0)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.AverageGrade)
                .ToList();

            foreach (var student in studentGrades)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
            }
        }

        public static Student CreateStudent(string name, List<double> grades)
        {
            var newStudent = new Student
            {
                Name = name,
                Grades = grades
            };

            return newStudent;
        }
    }
}
