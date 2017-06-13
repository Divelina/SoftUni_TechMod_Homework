using System;

namespace _15_BalancedBrackets
{
    public class BalancedBrackets
    {
        public static void Main()
        {
            var lineNum = int.Parse(Console.ReadLine());

            bool isBalanced = true;
            bool isOpened = false;

            for (int i = 1; i <= lineNum; i++)
            {
                var nextString = Console.ReadLine();

                if (isBalanced)
                {
                    if (nextString.Equals("("))
                    {
                        if (isOpened)
                        {
                            isBalanced = false;
                        }
                        else
                        {
                            isOpened = true;
                        }
                    }
                    else if (nextString.Equals(")"))
                    {
                        if (!isOpened)
                        {
                            isBalanced = false;
                        }
                        else
                        {
                            isOpened = false;
                        }
                    }
                }
            }
            
            if (isBalanced && !isOpened)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
