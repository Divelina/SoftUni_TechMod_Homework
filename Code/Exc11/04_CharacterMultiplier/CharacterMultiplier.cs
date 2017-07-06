using System;
using System.Linq;

namespace _04_CharacterMultiplier
{
   public class CharacterMultiplier
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            var shorterStr = string.Empty;
            var longerStr = GiveLongerWord(input[0], input[1], out shorterStr);

            var sumMultipliedAscii = 0L;

            for (int i = 0; i < shorterStr.Length; i++)
            {
                sumMultipliedAscii += ((int)shorterStr[i]) * ((int)longerStr[i]);
            }

            for (int i = shorterStr.Length; i < longerStr.Length; i++)
            {
                sumMultipliedAscii += (int)longerStr[i];
            }

            Console.WriteLine(sumMultipliedAscii);

        }

        public static string GiveLongerWord(string v1, string v2, out string shorterStr)
        {
            if ( v1.Length >= v2.Length)
            {
                shorterStr = v2;
                return v1;
            }
            else
            {
                shorterStr = v1;
                return v2;
            }
        }
    }
}
