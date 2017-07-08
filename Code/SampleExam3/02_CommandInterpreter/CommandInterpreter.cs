using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_CommandInterpreter
{
    public class CommandInterpreter
    {
        public static void Main()
        {
            var strArray = Console.ReadLine()
                .Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var command = Console.ReadLine();

            while (command != "end")
            {
                var splitCommand = command.Split(' ').ToArray();

                if (splitCommand[0] == "reverse" || splitCommand[0] == "sort")
                {
                    var startIndex = int.Parse(splitCommand[2]);
                    var countElm = int.Parse(splitCommand[4]);

                    var isValid = startIndex >= 0 && startIndex < strArray.Count 
                        && countElm >= 0 && startIndex + countElm - 1 < strArray.Count;

                    if (isValid)
                    {
                        var changedPortion = strArray.Skip(startIndex).Take(countElm).ToList();

                        if (splitCommand[0] == "reverse")
                        {
                            changedPortion.Reverse();
                        }
                        else
                        {
                            changedPortion.Sort();
                        }

                        for (int i = startIndex; i < startIndex + countElm; i++)
                        {
                            if (i >= strArray.Count)
                            {
                                break;
                            }
                            strArray[i] = changedPortion[i - startIndex];
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else
                {
                    var rollCount = int.Parse(splitCommand[1]);

                    if (rollCount >= 0)
                    {
                        if (splitCommand[0] == "rollLeft")
                        {
                            RollLeft(strArray, rollCount);
                        }
                        else
                        {
                            RollRight(strArray, rollCount);
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }

                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{String.Join(", ", strArray)}]");
        }

        public static void RollLeft(List<string> arr, int rolls)
        {
            var steps = rolls % arr.Count();

            for (int i = 1; i <= steps; i++)
            {
                var firstElement = arr[0];

                arr.RemoveAt(0);
                arr.Add(firstElement);
            }
        }

        public static void RollRight(List<string> arr, int rolls)
        {
            var steps = rolls % arr.Count();

            for (int i = 1; i <= steps; i++)
            {
                var lastElement = arr[arr.Count - 1];

                arr.Insert(0, lastElement);
                arr.RemoveAt(arr.Count - 1);
            }
        }
    }
}
