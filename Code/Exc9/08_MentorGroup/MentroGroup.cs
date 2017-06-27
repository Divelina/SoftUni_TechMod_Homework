using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _08_MentorGroup
{
    public class Student
    {
        public string Name { get; set; }
        public List<DateTime> AttendDate { get; set; }
        public List<string> Comments { get; set; }
    }

    public class MentroGroup
    {
        public static void Main()
        {
            var students = new Dictionary<string, Student>();

            var nextStudent = Console.ReadLine();

            while (nextStudent != "end of dates")
            {
                var visitInfo = nextStudent.Split(' ').ToArray();

                var name = visitInfo[0];

                if (!students.ContainsKey(name))
                {
                    var newStudent = CreateNewStudent(name);
                    students[name] = newStudent;
                }

                

                if (visitInfo.Length > 1)
                {
                    var visits = visitInfo[1].Split(',').ToArray();

                    for (int i = 0; i < visits.Length; i++)
                    {
                        var nextDate = DateTime.ParseExact(visits[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        students[name].AttendDate.Add(nextDate);
                    }
                }

                nextStudent = Console.ReadLine();
            }

            var commentLine = Console.ReadLine();

            while (commentLine != "end of comments")
            {
                var comment = commentLine.Split('-').ToArray();

                var name = comment[0];

                if (students.ContainsKey(name))
                {
                    students[name].Comments.Add(comment[1]);
                }

                commentLine = Console.ReadLine();
            }

            foreach (var person in students.Keys)
            {
                students[person].AttendDate = students[person]
                    .AttendDate
                    .OrderBy(dt => dt)
                    .ToList();
            }

            students = students
                .OrderBy(st => st.Key)
                .ToDictionary(st => st.Key, st => st.Value);

            foreach (var person in students)
            {
                Console.WriteLine(person.Key);
                Console.WriteLine("Comments:");

                foreach (var comment in person.Value.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");

                foreach (var date in person.Value.AttendDate)
                {
                    Console.WriteLine($"-- {date:dd/MM/yyyy}");
                }
            }
        }

        public static Student CreateNewStudent(string name)
        {
            var theStudent = new Student
            {
                Name = name,    
                AttendDate = new List<DateTime>(),
                Comments = new List<string>()
            };

            return theStudent;
        }
    }
}
