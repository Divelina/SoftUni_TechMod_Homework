using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_SrbskoUnleashed
{
    public class SrbskoUnleashed
    {
        public static void Main()
        {
            var singerProfit = new Dictionary<string, Dictionary<string, int>>();
            var line = Console.ReadLine();

            while (line != "End")
            {
                var split = line
                    .Split(' ')
                    .ToList();

                var venueIndex = 0;

                for (int i = 0; i < split.Count; i++)
                {
                    if (split[i].StartsWith("@"))
                    {
                        venueIndex = i;
                        break;
                    }
                }

                var venueLastIndex = split.Count - 3;
                bool isValidFormat = (venueIndex > 0) && (venueIndex < 4) && (venueLastIndex - venueIndex >= 0) && (venueLastIndex - venueIndex  <= 2);

                var tickets = 0;
                var ticketPrice = 0;

                isValidFormat = isValidFormat && int.TryParse(split[split.Count - 1], out tickets) && int.TryParse(split[split.Count -2], out ticketPrice);

                if (isValidFormat)
                {
                    split[venueIndex] = split[venueIndex].Substring(1);

                    var singer = String.Join(" ", split.Take(venueIndex).ToArray());
                    var venue = String.Join(" ", split.Skip(venueIndex).Take(venueLastIndex - venueIndex + 1).ToArray());
                    var cash = tickets * ticketPrice;

                    if (!singerProfit.ContainsKey(venue))
                    {
                        singerProfit[venue] = new Dictionary<string, int>();
                    }

                    if (!singerProfit[venue].ContainsKey(singer))
                    {
                        singerProfit[venue][singer] = 0;
                    }

                    singerProfit[venue][singer] += cash;
                }

                line = Console.ReadLine();
            }

            singerProfit = singerProfit
                .ToDictionary(x => x.Key, x => 
                    x.Value.OrderByDescending(s => s.Value)
                    .ToDictionary(s => s.Key, s => s.Value));

            foreach (var venue in singerProfit)
            {
                Console.WriteLine($"{venue.Key}");

                foreach (var singer in venue.Value)
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }



        }
    }
}
