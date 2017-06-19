using System;
using System.Linq;

namespace _02_ManipulateArray
{
    public class ManipulateArr
    {
        public static void Main()
        {
            var inputArr = Console.ReadLine();

            var lineNum = int.Parse(Console.ReadLine());
            var command = string.Empty;

            for (int i = 1; i <= lineNum; i++)
            {
                var strArr = inputArr.Split(' ').ToArray();
                
                command = Console.ReadLine();

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
                    var index = int.Parse(splCom[1]);
                    var str = splCom[2];

                    strArr[index] = str;
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
            }

            var output = inputArr.Split(' ').ToArray();

            Console.WriteLine(String.Join(", ", output));
        }

        public static void DeleteNonUnique(string[] arr)
        {       
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < i; j++)
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
            for (int i = 0; i < arr.Length/2; i++)
            {
                var transfer = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = transfer;
            }
        }
    }
}
