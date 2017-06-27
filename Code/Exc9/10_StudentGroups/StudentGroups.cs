using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _10_StudentGroups
{
    public class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegDate { get; set; }
    }

    public class Town
    {
        public string Name { get; set; }
        public int Seats { get; set; }
        public List<Student> Students {get; set;}
    }

    public class Group
    {
        public Town Town { get; set; }
        public int Index { get; set; }
        public List<Student> Students { get; set; }
    }

    public class StudentGroups
    {
        public static void Main()
        {
            var nextLine = Console.ReadLine();

            var lastTown = new Town();
            var townList = new List<Town>();

            while (nextLine != "End")
            {
                if (nextLine.Contains("=>"))
                {
                    var splitTown = nextLine.Split('>').ToArray();

                    var townName = splitTown[0].Trim('=').Trim();
                    var theSeats = splitTown[1].Trim().Split(' ').ToArray();
                    var seatCapacity = int.Parse(theSeats[0]);

                    var newTown = CreateNewTown(townName, seatCapacity);
                    townList.Add(newTown);
                    lastTown = newTown;
                }
                else
                {
                    var splitStudent = nextLine.Split('|').ToArray();
                    var studentName = splitStudent[0].Trim();
                    var studentEmail = splitStudent[1].Trim();
                    var regDate = DateTime
                        .ParseExact(splitStudent[2].Trim(), "d-MMM-yyyy", CultureInfo.InstalledUICulture);

                    var newStudent = CreateNewStudent(studentName, studentEmail, regDate);
                    lastTown.Students.Add(newStudent);
                }

                nextLine = Console.ReadLine();
            }

            var groupList = new List<Group>();

            foreach (var place in townList)
            {
                place.Students = place.Students
                    .OrderBy(st => st.RegDate)
                    .ThenBy(st => st.Name)
                    .ThenBy(st => st.Email)
                    .ToList();

                for (int i = 0; i < place.Students.Count; i += place.Seats)
                {
                    var index = i / place.Seats;
                    var currentGroup = CreateNewGroup(place, index);


                    for (int j = i; j < i + place.Seats; j++)
                    {
                        if (j >= place.Students.Count)
                        {
                            break;
                        }
                        var currentStudent = place.Students[j];
                        currentGroup.Students.Add(currentStudent);
                    }

                    groupList.Add(currentGroup);
                }
            }
                groupList = groupList.OrderBy(gr => gr.Town.Name).ToList();

                Console.WriteLine($"Created {groupList.Count} groups in {townList.Count} towns:");

                foreach (var gr in groupList)
                {
                    var emails = gr.Students.Select(st => st.Email).ToList();
                    Console.WriteLine($"{gr.Town.Name} => {String.Join(", ", emails)}");
                }
        }

        public static Group CreateNewGroup(Town place, int index)
        {
            var theGroup = new Group
            {
                Town = place,
                Index = index,
                Students = new List<Student>()
            };

            return theGroup;
        }

        public static Student CreateNewStudent(string studentName, string studentEmail, DateTime regDate)
        {
            var theStudent = new Student
            {
                Name = studentName,
                Email = studentEmail,
                RegDate = regDate 
            };

            return theStudent;
        }

        public static Town CreateNewTown(string townName, int seatCapacity)
        {
            var theTown = new Town
            {
                Name = townName,
                Seats = seatCapacity,
                Students = new List<Student>()
            };

            return theTown;
        }
    }
}
