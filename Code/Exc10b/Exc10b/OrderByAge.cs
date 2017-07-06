using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    public class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }

    public class OrderByAge
    {
        public static void Main()
        {
            var personList = new List<Person>();

            var line = Console.ReadLine();

            while (line != "End")
            {
                var splitLine = line.Split(' ').ToArray();

                var name = splitLine[0];
                var id = splitLine[1];
                var age = int.Parse(splitLine[2]);

                var nextPerson = new Person
                {
                    Name = name,
                    ID = id,
                    Age = age
                };

                personList.Add(nextPerson);

                line = Console.ReadLine();
            }

            personList = personList.OrderBy(p => p.Age).ToList();

            foreach (var prsn in personList)
            {
                Console.WriteLine($"{prsn.Name} with ID: {prsn.ID} is {prsn.Age} years old.");
            }
        }
    }
}
