using System;
using System.Linq;
    
namespace Exc6
{
    public class LargestCommonEnd
    {
        public static void Main()
        {
            var words1 = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var words2 = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var lng = Math.Min(words1.Length, words2.Length);

            var commonPartLeft = 0;
            var outputLeft = string.Empty;

            for (int i = 0; i < lng; i++)
            {
                if (words1[i] != words2[i])
                {
                    break;
                }

                commonPartLeft++;
            }

            var commonPartRight = 0;

            for (int i = 0; i < lng; i++)
            {
                if (words1[words1.Length -1-i] != words2[words2.Length -1 -i])
                {
                    break;
                }

                commonPartRight++;
            }

            if ((commonPartLeft >= commonPartRight) && (commonPartLeft > 0) )
            {
                Console.WriteLine($"{commonPartLeft}");
            }
            else if ((commonPartLeft < commonPartRight) && (commonPartRight > 0))
            {
                Console.WriteLine($"{commonPartRight}");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
