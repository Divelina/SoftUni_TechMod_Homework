using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_SumBigNum
{
    public class SumBigNum
    {
        public static void Main()
        {
            var bigNum = Console.ReadLine().TrimStart('0');
            var multiplier = int.Parse(Console.ReadLine());

            var toAddToNextDigit = 0;
            var answer = string.Empty;


            if (multiplier == 0)
            {
                answer = "0";
            }
            else
            {
                for (int i = bigNum.Length - 1; i >= 0; i--)
                {
                    var resultingDigit = 0;

                    if (bigNum[i] != '.')
                    {

                        var multiplied = int.Parse(bigNum[i].ToString()) * multiplier + toAddToNextDigit;

                        if (multiplied / 10 > 0)
                        {
                            toAddToNextDigit = multiplied / 10;
                            resultingDigit = multiplied % 10;
                        }
                        else
                        {
                            toAddToNextDigit = 0;
                            resultingDigit = multiplied;
                        }

                        answer = resultingDigit + answer;
                    }
                    else
                    {
                        answer = bigNum[i] + answer;
                    }
                }

                if (toAddToNextDigit > 0)
                {
                    answer = toAddToNextDigit + answer;
                }

            }
           
            Console.WriteLine(answer);
        }
    }
}
