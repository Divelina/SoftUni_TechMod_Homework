using System;
using System.Linq;

namespace _05_RoundingAwayFromZeor
{
    public class RoundingAwayZero
    {
        public static void Main()
        {
            var inputArr = Console.ReadLine()
                .Split(' ')
                .ToArray();


            for (int i = 0; i < inputArr.Length; i++)
            {
                int rounded = 0;
                double currentEl = double.Parse(inputArr[i]);
                string stringged = inputArr[i].TrimEnd('0');
                int lng = stringged.Length;

                if ((lng >= 2) && (stringged[lng - 2] == '.') && (stringged[lng - 1] == '5'))
                {
                    if (currentEl>= 0)
                    {
                        rounded = (int)Math.Ceiling(currentEl);
                    }
                    else
                    {
                        rounded = (int)Math.Floor(currentEl);
                    }

                }
                else
                {
                    rounded = (int)Math.Round(currentEl);
                }

                Console.WriteLine($"{inputArr[i]} => {rounded}");
            }
        }
    }
}
