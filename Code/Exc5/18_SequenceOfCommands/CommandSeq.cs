using System;
using System.Linq;
using System.Numerics;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        BigInteger[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(BigInteger.Parse)
            .ToArray();

        string command = Console.ReadLine();

        while (!command.Equals("stop"))
        {
            string line = command.Trim();
            string[] stringParams = line.Split(ArgumentsDelimiter);
            int[] args = new int[2];

            command = stringParams[0];

            if (command.Equals("add") ||
                command.Equals("subtract") ||
                command.Equals("multiply"))
            {
                args[0] = int.Parse(stringParams[1]);
                args[1] = int.Parse(stringParams[2]);

                PerformAction(array, command, args);
            }
            else
            {
                PerformAction(array, command, args);
            }

            PrintArray(array);

            command = Console.ReadLine();
        }
    }

    static void PerformAction(BigInteger[] arr, string action, int[] args)
    {
        int pos = args[0] -1;
        int value = args[1];

        switch (action)
        {
            case "multiply":
                arr[pos] *= value;
                break;
            case "add":
                arr[pos] += value;
                break;
            case "subtract":
                arr[pos] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(arr);
                break;
            case "rshift":
                ArrayShiftRight(arr);
                break;
        }
        
    }

    private static void ArrayShiftRight(BigInteger[] array)
    {
        var lastEl = array[array.Length - 1];

        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }

        array[0] = lastEl;
    }

    private static void ArrayShiftLeft(BigInteger[] array)
    {
        var firstEl = array[0];

        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }

        array[array.Length - 1] = firstEl;
    }

    private static void PrintArray(BigInteger[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();
    }
}
