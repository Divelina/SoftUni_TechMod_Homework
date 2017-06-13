using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_BoatSimulator
{
    public class BoatSim
    {
        public static void Main()
        {
            var firstBoatCh = char.Parse(Console.ReadLine());
            var secondBoatCh = char.Parse(Console.ReadLine());
            var firstSpeed = 0;
            var secondSpeed = 0;
        
            var lineNum = int.Parse(Console.ReadLine());

            bool isThereWinner = false;

            for (int i = 1; i <= lineNum; i++)
            {
                var speed = Console.ReadLine();

                if (!isThereWinner)
                {
                    if (speed == "UPGRADE")
                    {
                        firstBoatCh = (char)((int) firstBoatCh + 3);
                        secondBoatCh = (char)((int)secondBoatCh + 3);
                    }
                    else
                    {
                        firstSpeed += (i % 2) * speed.Length;
                        secondSpeed += ((i+1) % 2) *speed.Length;
                    }
                    
                    if (firstSpeed >= 50)
                    {
                        Console.WriteLine(firstBoatCh);
                        isThereWinner = true;
                    }
                    else if (secondSpeed >= 50)
                    {
                        Console.WriteLine(secondBoatCh);
                        isThereWinner = true;
                    }
                }
            }

            if (!isThereWinner)
            {
                if (firstSpeed >= secondSpeed)
                {
                    Console.WriteLine(firstBoatCh);
                }
                else
                {
                    Console.WriteLine(secondBoatCh);
                }
            }
        }
    }
}
