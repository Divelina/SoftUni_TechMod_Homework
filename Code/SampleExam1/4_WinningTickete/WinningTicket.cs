using System;
using System.Text.RegularExpressions;

namespace _4_WinningTicket
{
    public class Program
    {
        public static void Main()
        {
            var tickets = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            
            var pattern = @"(\@{6,10}|\#{6,10}|\${6,10}|\^{6,10}).*?x.*?\1";
            
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i].Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    var ticketCode = "";

                    for (int j = 0; j < 10; j++)
                    {
                        ticketCode += tickets[i][j];
                    }

                    ticketCode += "x";

                    for (int j = 10; j < 20; j++)
                    {
                        ticketCode += tickets[i][j];
                    }

                    var regex = new Regex(pattern);
                    var doesMatch = regex.Match(ticketCode);

                    if (!doesMatch.Success)
                    {
                        Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                    }
                    else if (doesMatch.Groups[1].Length == 10)
                    {
                        Console.WriteLine($"ticket \"{tickets[i]}\" - {10}{doesMatch.Groups[1].Value[0]} Jackpot!");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{tickets[i]}\" - {doesMatch.Groups[1].Length}{doesMatch.Groups[1].Value[0]}");
                    }
                }
            }


        }
    }
}
