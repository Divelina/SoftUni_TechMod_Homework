using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _04_PunctuationFinder
{
    class PunctuationFinder
    {
        static void Main(string[] args)
        {
            var searched = new char[]
            {
                '.', ',', '?', '!', ':'
            };

            var text = File.ReadAllText("../../sample_text.txt");
            var output = new List<char>();

            foreach (var symb in text)
            {
                if (searched.Contains(symb))
                {
                    output.Add(symb);
                }
            }

            var extracted = String.Join(", ", output);

            File.WriteAllText("../../output_04_PunctuationFinder.txt", extracted);
        }
    }
}
