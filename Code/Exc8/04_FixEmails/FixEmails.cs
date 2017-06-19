using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_FixEmails
{
    public class FixEmails
    {
        public static void Main()
        {
            var nameEmails = new Dictionary<string, string>();
            var line = Console.ReadLine();

            while (line != "stop")
            {
                var name = line;
                var email = Console.ReadLine();

                var emailEnd = email[email.Length - 2].ToString() + email[email.Length - 1].ToString();
                emailEnd = emailEnd.ToLower();

                if (emailEnd != "us" && emailEnd != "uk")
                {
                    nameEmails[name] = email;
                }

                line = Console.ReadLine();
            }

            foreach (var entry in nameEmails)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }
}
