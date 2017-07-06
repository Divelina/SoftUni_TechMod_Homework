using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_PlayCatch
{
    public class PlayCatch
    {
        public static void Main()
        {
            var intArr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var caught = 0;

            while (caught < 3)
            {
                var command = Console.ReadLine().Split(' ').ToArray();

                var index = -1;
                var isCaught = false;

                if (!int.TryParse(command[1], out index))
                {
                    Console.WriteLine($"The variable is not in the correct format!");
                    caught++;
                    isCaught = true;
                }
                else if (index > intArr.Count - 1 || index < 0)
                {
                    Console.WriteLine($"The index does not exist!");
                    caught++;
                    isCaught = true;
                }

                if (!isCaught)
                {
                    if (command[0] == "Replace")
                    {
                        var element = 0;

                        if (!int.TryParse(command[2], out element))
                        {
                            Console.WriteLine($"The variable is not in the correct format!");
                            caught++;
                        }
                        else
                        {
                            intArr.RemoveAt(index);
                            intArr.Insert(index, element);
                        }
                    }
                    else if (command[0] == "Print")
                    {
                        var endIndex = -1;

                        if (!int.TryParse(command[2], out endIndex))
                        {
                            Console.WriteLine($"The variable is not in the correct format!");
                            caught++;
                        }
                        else if (endIndex > intArr.Count - 1 || endIndex < 0)
                        {
                            Console.WriteLine($"The index does not exist!");
                            caught++;
                        }
                        else
                        {
                            var toPrint = new List<int>();
                            for (int i = index; i <= endIndex; i++)
                            {
                                toPrint.Add(intArr[i]);
                            }

                            Console.WriteLine(string.Join(", ", toPrint));
                        }
                    }
                    else if (command[0] == "Show")
                    {
                        Console.WriteLine(intArr[index]);
                    }
                }
            }

            Console.WriteLine(String.Join(", ", intArr));
        }
    }
}
