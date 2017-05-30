using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_NeighborWars
{
    public class NeighborWars
    {
        public static void Main()
        {
            var peshoAttackPower = int.Parse(Console.ReadLine());
            var goshoAttackPower = int.Parse(Console.ReadLine());

            var peshoHealth = 90;
            var goshoHealth = 90;

            var peshoHit = "Roundhouse kick";
            var goshoHit = "Thunderous fist";

            var roundCount = 0;
            var attacker = string.Empty;
            var attacked = string.Empty;
            var hitType = string.Empty;
            var health = 0;

            while (true)
            {
                roundCount++;
                if (roundCount % 3 == 1)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }

                if (roundCount % 2 == 1)
                {
                    attacker = "Pesho";
                    attacked = "Gosho";
                    hitType = peshoHit;
                    goshoHealth -= peshoAttackPower;
                    health = goshoHealth;
                }
                else
                {
                    attacker = "Gosho";
                    attacked = "Pesho";
                    hitType = goshoHit;
                    peshoHealth -= goshoAttackPower;
                    health = peshoHealth;
                }

                if (health > 0)
                {
                    Console.WriteLine($"{attacker} used {hitType} and reduced {attacked} to {health} health.");
                }
                else
                {
                    Console.WriteLine($"{attacker} won in {roundCount}th round.");
                    break;
                }
            }

        }
    }
}
