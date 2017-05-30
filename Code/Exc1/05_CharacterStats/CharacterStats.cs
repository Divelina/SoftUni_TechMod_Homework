using System;

namespace _05_CharacterStats
{
    public class CharacterStats
    {
        public static void Main()
        {
            var characterName = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            var healthStat = "|" + new string('|', currentHealth)
                + new string('.', maxHealth - currentHealth) + "|";
            var energyStat = "|" + new string('|', currentEnergy)
                + new string('.', maxEnergy - currentEnergy) + "|";

            Console.WriteLine($"Name: {characterName}");
            Console.WriteLine($"Health: {healthStat}");
            Console.WriteLine($"Energy: {energyStat}");
        }
    }
}
