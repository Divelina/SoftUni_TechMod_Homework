using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_SumArrays
{
    public class SumArrays
    {
        public static void Main()
        {
            var firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var maxLng = Math.Max(firstArr.Length, secondArr.Length);

            var sumArr = new int[maxLng];

            for (int i = 0; i < maxLng; i++)
            {
                sumArr[i] = firstArr[i % firstArr.Length] + secondArr[i % secondArr.Length];
            }

            Console.WriteLine(String.Join(" ", sumArr));
        }
    }
}
