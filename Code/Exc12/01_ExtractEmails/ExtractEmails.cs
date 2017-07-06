using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01_ExtractEmails
{
   public class ExtractEmails
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            var pattern = @"(\s|^)[a-zA-Z0-9]+[a-zA-Z0-9.\-_]*[a-zA-Z0-9]+@[a-zA-Z0-9]+[a-zA-Z0-9-\.]*[a-zA-Z0-9]+\.[a-zA-Z0-9]+[a-zA-Z0-9-]*[a-zA-Z0-9]";
            var emailReg = new Regex(pattern);

            MatchCollection emails = emailReg.Matches(text);

            var output = new List<string>();

            for (int i = 0; i < emails.Count; i++)
            {
                var current = emails[i].ToString().Trim();
                output.Add(current);   
            }

            foreach (var email in output)
            {
                Console.WriteLine(email);
            }
        }
    }
}
