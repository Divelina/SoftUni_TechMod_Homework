using System;

namespace _02_AdvertismentMessage
{
    public class AddvertisementMessage
    {
        public static void Main()
        {
            var phrases = new string[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            var events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            var authors = new string[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            var cities = new string[]
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            var lineNum = int.Parse(Console.ReadLine());

            Random rnd = new Random();

            for (int i = 1; i <= lineNum; i++)
            {
                var phrase = phrases[rnd.Next(0, phrases.Length)];
                var theEvent = events[rnd.Next(0, events.Length)];
                var author = authors[rnd.Next(0, authors.Length)];
                var city = cities[rnd.Next(0, cities.Length)];

                Console.WriteLine($"{phrase} {theEvent} {author} - {city}");
            }
        }
    }
}
