using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04_CubicsMessages
{
    public class CubicsMessages
    {
        public static void Main()
        {
            var message = Console.ReadLine();

            while (message != "Over!")
            {
                var lng = int.Parse(Console.ReadLine());

                var pattern = @"^(\d*)([a-zA-Z]{" + lng + @"})([^a-zA-Z]*)$";
                var msgRegex = new Regex(pattern);

                if (msgRegex.IsMatch(message))
                {
                    var theMessage = msgRegex.Match(message).Groups[2].ToString();
                    var rest = msgRegex.Match(message).Groups[1].ToString() 
                        + msgRegex.Match(message).Groups[3].ToString();

                    var verification = FindCode(rest, theMessage);

                    Console.WriteLine($"{theMessage} == {verification}");
                }

                message = Console.ReadLine();
            }

        }

        public static string FindCode(string rest, string theMessage)
        {
            var output = string.Empty;

            foreach (var ch in rest)
            {
                if (ch >= '0' && ch <='9')
                {
                    var index = int.Parse(ch.ToString());

                    if (index >=0 && index < theMessage.Length)
                    {
                        output += theMessage[index];
                    }
                    else
                    {
                        output += " ";
                    }
                }
            }

            return output;
        }
    }
}
