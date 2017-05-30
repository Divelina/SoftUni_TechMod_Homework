using System;

namespace _05_ForeignLanguages
{
    public class ForeignLanguages
    {
        public static void Main()
        {
            var country = Console.ReadLine();
            var language = string.Empty;

            switch (country)
            {
                case "England":
                case "USA":    language = "English"; break;
                case "Spain":
                case "Argentina":
                case "Mexico": language = "Spanish"; break;
                default: language = "unknown"; break;
            }

            Console.WriteLine($"{language}");
        }
    }
}
