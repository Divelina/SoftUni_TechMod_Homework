using System;
using System.Linq;

namespace _04_MorseCodeUpgraded
{
    public class MorseCodeUpgraded
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split('|').ToArray();
            var result = string.Empty;

            foreach (var code in input)
            {
                var asciiCode = 0;
                var countSequenceLength = 1;
                var previousDigit = -1;

                foreach (var digit in code)
                {
                    if (digit == '0')
                    {
                        asciiCode += 3;
                    }
                    else
                    {
                        asciiCode += 5;
                    }

                    if (int.Parse(digit.ToString()) == previousDigit)
                    {
                        countSequenceLength++;
                    }
                    else if (countSequenceLength > 1)
                    {
                        asciiCode += countSequenceLength;
                        countSequenceLength = 1;
                    }

                    previousDigit = int.Parse(digit.ToString());
                }

                if (countSequenceLength > 1)
                {
                    asciiCode += countSequenceLength;
                }

                result += (char)asciiCode;
            }

            Console.WriteLine(result);
        }
    }
}
