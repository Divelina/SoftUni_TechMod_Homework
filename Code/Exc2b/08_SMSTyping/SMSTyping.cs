using System;

namespace _08_SMSTyping
{
    public class SMSTyping
    {
        public static void Main(string[] args)
        {
            var charNum = int.Parse(Console.ReadLine());
            var message = string.Empty;

            var iniAscii = (int)'a';
            var keys = string.Empty;
            var code = 0;

            for (int i = 1; i <= charNum; i++)
            {
                keys = Console.ReadLine();
                code = int.Parse(keys[0].ToString());

                if (code == 0)
                {
                    message += " ";
                }
                else {
                    if (code == 8 || code == 9)
                    {
                        code = (code - 2) * 3 + 1;
                    }
                    else
                    {
                        code = (code - 2) * 3;
                    }

                    code += keys.Length - 1;
                    code += iniAscii;
                    message += (char)code;
                }                        
            }

            Console.WriteLine(message);
        }
    }
}
