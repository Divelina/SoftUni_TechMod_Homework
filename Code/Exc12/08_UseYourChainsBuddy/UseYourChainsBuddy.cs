using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _08_UseYourChainsBuddy
{
    public class UseYourChainsBuddy
    {
       public static void Main()
        {

            var input = Console.ReadLine();

            var pattern = @"<p>(.*?)<\/p>";
            var paraRegex = new Regex(pattern);
            MatchCollection paraMatch = paraRegex.Matches(input);

            var paragraphs = new List<string>();

            foreach (Match text in paraMatch)
            {
                var decrypted = text.Groups[1].ToString();

                var result = string.Empty;
                var lastChar = 'x';

                for (int i = 0; i < decrypted.Length; i++)
                {
                    var ch = decrypted[i];
                    if (ch >= '0' && ch <= '9')
                    {
                        result += ch;
                        lastChar = ch;
                    }
                    else if (ch >= 'a' && ch <= 'm')
                    {
                        int ascii = ch + 'n' - 'a';
                        ch = (char)ascii;
                        result += ch;
                        lastChar = ch;
                    }
                    else if (ch >= 'n' && ch <= 'z')
                    {
                        int ascii = ch - 'n' + 'a';
                        ch = (char)ascii;
                        result += ch;
                        lastChar = ch;
                    }
                    else
                    {
                        ch = ' ';
                        if (lastChar != ' ')
                        {
                            result += ch;
                        }
                        lastChar = ch;
                    }
                }

                paragraphs.Add(result);
            }

            Console.WriteLine(String.Join("", paragraphs));
        }
    }
}
