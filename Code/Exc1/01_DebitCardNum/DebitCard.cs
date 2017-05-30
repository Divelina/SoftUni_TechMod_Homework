using System;

namespace _01_DebitCardNum
{
    public class DebitCard
    {
        public static void Main()
        {
            var firstInt = int.Parse(Console.ReadLine());
            var secondInt = int.Parse(Console.ReadLine());
            var thirdInt = int.Parse(Console.ReadLine());
            var fourthInt = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstInt:0000} {secondInt:0000} {thirdInt:0000} {fourthInt:0000}");
        }
    }
}
