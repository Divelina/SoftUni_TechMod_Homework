using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_MExchangeableWords
{
    public class MExchangeableWords
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            var areExchangable = true;
            var charCorrespondense = new Dictionary<char, char>();

            if (CountDiffChars(input[0]) == CountDiffChars(input[1]))
            {
                var minLength = Math.Min(input[0].Length, input[1].Length);

                for (int i = 0; i < minLength; i++)
                {
                    if (!charCorrespondense.ContainsKey(input[0][i]))
                    {
                        charCorrespondense[input[0][i]] = input[1][i];
                    }
                    else
                    {
                        if (charCorrespondense[input[0][i]] != input[1][i])
                        {
                            areExchangable = false;
                            break;
                        }
                    }
                }

            }
            else
            {
                areExchangable = false;
            }

            if (areExchangable)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }

        public static int CountDiffChars(string v)
        {
            var charList = new List<char>();

            for (int i = 0; i < v.Length; i++)
            {
                if (!charList.Contains(v[i]))
                {
                    charList.Add(v[i]);
                }
            }

            return charList.Count;
        }
    }
}
