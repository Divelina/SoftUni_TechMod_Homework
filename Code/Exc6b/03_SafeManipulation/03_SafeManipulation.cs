using System;
using System.Linq;

namespace _03_SafeManipulation
{
    public class Program
    {
        public static void Main()
        {
            var inputArr = Console.ReadLine();

            var command = Console.ReadLine();

            while (command != "END")
            {
                var strArr = inputArr.Split(' ').ToArray();
                
                if (command == "Reverse")
                {
                    Reverse(strArr);
                }
                else if (command == "Distinct")
                {
                    DeleteNonUnique(strArr);
                }
                else
                {
                    var splCom = command.Split(' ').ToArray();
                    var com = splCom[0];

                    if (com == "Replace")
                    {
                        var index = int.Parse(splCom[1]);
                        var str = splCom[2];

                        if ((index < 0) || (index > strArr.Length - 1))
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        else
                        {
                            strArr[index] = str;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    
                }

                inputArr = string.Empty;

                for (int j = 0; j < strArr.Length; j++)
                {
                    if (strArr[j] != null)
                    {
                        inputArr += strArr[j] + " ";
                    }
                }

                inputArr = inputArr.Trim();

                command = Console.ReadLine();
            }

            var output = inputArr.Split(' ').ToArray();

            Console.WriteLine(String.Join(", ", output));
        }

        public static void DeleteNonUnique(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        arr[i] = null;
                        break;
                    }
                }
            }
        }

        public static void Reverse(string[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                var transfer = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = transfer;
            }
        }
    }
}
