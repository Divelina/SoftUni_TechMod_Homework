using System;

namespace _03_EmployeeData
{
    public class EmployeeData
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var id = Console.ReadLine();
            var salary = double.Parse(Console.ReadLine());

            var zeroNum = 8 - id.Length;
            var employeeID = "";

            for (int i = 1; i <= zeroNum; i++)
            {
                employeeID += "0";
            }

            employeeID += id;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {employeeID}");
            Console.WriteLine($"Salary: {salary:F2}");
        }
    }
}
