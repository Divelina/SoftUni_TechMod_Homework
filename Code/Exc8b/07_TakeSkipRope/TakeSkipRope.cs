using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_TakeSkipRope
{
    public class TakeSkipRope
    {
        public static void Main()
        {
            var str = Console.ReadLine();

            var takeList = new List<int>();
            var skipList = new List<int>();
            var letterList = new List<char>();

            bool isEven = true;

            for (int i = 0; i < str.Length; i++)
            {
                var index = 0;

                if (int.TryParse(str[i].ToString(), out index))
                {
                    if (isEven)
                    {
                        takeList.Add(index);
                    }
                    else
                    {
                        skipList.Add(index);
                    }

                    isEven = !isEven;
                }
                else
                {
                    letterList.Add(str[i]);
                }
            }

            //Console.WriteLine(String.Join(" ", takeList));
            //Console.WriteLine(String.Join(" ", skipList));
            //Console.WriteLine(String.Join(" ", letterList));

            var result = string.Empty;
            var skipped = 0;

            for (int i = 0; i < skipList.Count; i++)
            {
                var currentStr = letterList  
                    .Skip(skipped) 
                    .Take(takeList[i])
                    .ToList();

                skipped += skipList[i] + takeList[i];

                result += String.Join("", currentStr);
            }

            Console.WriteLine(result);
        }
    }
}
