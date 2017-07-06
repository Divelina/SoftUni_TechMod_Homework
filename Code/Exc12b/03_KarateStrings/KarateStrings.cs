using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KarateStrings
{
    public class KarateStrings
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var nextIndex = input.IndexOf(">");
            var punchPower = 0;

            while (nextIndex >= 0)
            {
                punchPower = int.Parse(input[nextIndex + 1].ToString());
                var j = nextIndex + 1;

                for (int i = 1; i <= punchPower; i++)
                {
                    if (j <= input.Length - 1)
                    {

                        if (input[j] != '>')
                        {
                            input = input.Remove(j, 1);
                        }
                        else
                        {
                            punchPower += int.Parse(input[j + 1].ToString());
                            j++;
                            i--;
                        }
                    }
                }

                nextIndex = input.IndexOf(">", j);
            }

            Console.WriteLine(input);
        }
    }
}
