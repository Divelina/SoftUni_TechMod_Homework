using System;

namespace _06_DNASequence
{
    public class DNASequence
    {
        public static void Main()
        {
            var match = int.Parse(Console.ReadLine());

            var bases = new char[]
            {
                'A', 'C', 'G', 'T'
            };

            var currentSequence = string.Empty;
            var count = 1;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        currentSequence = bases[i - 1].ToString() 
                            + bases[j - 1].ToString() 
                            + bases[k - 1].ToString();

                        if ((i + j + k) >= match)
                        {
                            currentSequence = "O" + currentSequence + "O";
                        }
                        else
                        {
                            currentSequence = "X" + currentSequence + "X";
                        }

                        Console.Write(currentSequence);

                        if (count % 4 != 0)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.WriteLine();
                        }

                        count++;
                    }
                }
            }
        }
    }
}
