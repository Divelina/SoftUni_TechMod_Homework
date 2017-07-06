using System;
using System.Text;


namespace _09_MelrahShake
{
    public class MelrahShake
    {
        public static void Main()
        {
            var toShake = Console.ReadLine();
            var pattern = Console.ReadLine();

            while (pattern.Length > 0)
            {
                int firstIndex = toShake.IndexOf(pattern);
                int lastIndex = toShake.LastIndexOf(pattern);

                if (firstIndex != lastIndex)
                {
                    toShake = toShake.Remove(lastIndex, pattern.Length);
                    toShake = toShake.Remove(firstIndex, pattern.Length);
                    Console.WriteLine("Shaked it.");

                    var indexFromPattern = pattern.Length / 2;
                    pattern = pattern.Remove(indexFromPattern, 1);
                }
                else
                {
                    break;
                }
            }
            
            Console.WriteLine("No shake.");
            Console.WriteLine(toShake);
        }
    }
}
