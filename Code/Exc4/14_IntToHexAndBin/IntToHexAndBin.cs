using System;

namespace _14_IntToHexAndBin
{
    public class IntToHexAndBin
    {
        public static void Main()
        {
            var integerNum = int.Parse(Console.ReadLine());

            //var hexadecimalNum = Convert.ToString(integerNum, 16).ToUpper();
            var binnaryNum = Convert.ToString(integerNum, 2).ToUpper();

            var rest = integerNum;
            var times = integerNum;
            var result = string.Empty;

            while (times > 0)
            {
                rest = times % 16;

                if (rest <= 9)
                {
                    result = rest + result;
                }
                else
                {
                    switch (rest)
                        {
                        case 10:
                            result = "A" + result; break;
                        case 11:
                            result = "B" + result; break;
                        case 12:
                            result = "C" + result; break;
                        case 13:
                            result = "D" + result; break;
                        case 14:
                            result = "E" + result; break;
                        case 15:
                            result = "F" + result; break;
                        }
                }

                times = times / 16;
            }

            //Console.WriteLine(hexadecimalNum);
            Console.WriteLine(result);
            Console.WriteLine(binnaryNum);
            
        }
    }
}
