using System;
using System.Linq;

namespace _04_TripleSum
{
    public class TripleSum
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var inputNum = input.Split(' ').Select(long.Parse).ToArray();

            bool hitsExist = false;

            for (var i = 0; i < inputNum.Length; i++)
            {
                for (var j = i+1; j < inputNum.Length; j++)
                {
                    for (var k = 0; k < inputNum.Length; k++)
                    {

                        if ((inputNum[i] + inputNum[j]) == inputNum[k])
                        {
                            Console.WriteLine($"{inputNum[i]} + {inputNum[j]} == {inputNum[k]}");
                            hitsExist = true;
                            break;
                        }
                    }
                }
            }

            if (!hitsExist)
            {
                Console.WriteLine("No");
            }
        }
    }
}
