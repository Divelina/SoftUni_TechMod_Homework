using System;

namespace _13_VowelToDigit
{
    public class VowelOrDigit
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToLower();
            char testedChar = input[0];

            if ( testedChar >= '0' && testedChar <= '9')
            {
                Console.WriteLine("digit");
            }
            else if (testedChar == 'a' || testedChar == 'e' || testedChar == 'i' || testedChar == 'o' || testedChar == 'u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
