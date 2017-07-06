using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07_HideOut
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var hideout = string.Empty;
            var indexOfHideout = -1;
            

            char symbol;
            var reps = 0;

            ReadNextLine(out symbol, out reps);

            var isMatch = LookForString(inputLine, symbol, reps, out hideout);

            if (isMatch)
            {
                indexOfHideout = inputLine.IndexOf(hideout);
            }
            else
            {
                for (int i = 1; i <= 2; i++)
                {
                    ReadNextLine(out symbol, out reps);
                    isMatch = LookForString(inputLine, symbol, reps, out hideout);

                    if (isMatch)
                    {
                        indexOfHideout = inputLine.IndexOf(hideout);
                        if (i ==1)
                        {
                            ReadNextLine(out symbol, out reps);
                            break;
                        }
                    }
                }
            }

            Console.WriteLine($"Hideout found at index {indexOfHideout} and it is with size {hideout.Length}!");     
        }

        public static bool LookForString(string input, char symbol, int reps, out string hideout)
        {
            var pattern = new string (symbol, reps);
            hideout = string.Empty;

            if (input.Contains(pattern))
            {
                for (int i = input.IndexOf(pattern); i < input.Length; i++)
                {
                    if (input[i] == symbol)
                    {
                        hideout += symbol;     
                    }
                    else
                    {
                        break;
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ReadNextLine(out char symbol, out int reps)
        {
            var searched = Console.ReadLine().Split(' ').ToArray();

            symbol = char.Parse(searched[0]);
            reps = int.Parse(searched[1]);
        }
    }
}
