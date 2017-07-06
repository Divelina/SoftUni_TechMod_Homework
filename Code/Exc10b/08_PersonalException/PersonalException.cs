using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_PersonalException
{
    public class MyException : Exception
    {
        public MyException() : base("My first exception is awesome!!!")
        {

        }
    }

    public class PersonalException
    {
        public static void Main()
        {
            while (true)
            {
                var num = decimal.Parse(Console.ReadLine());

                try
                {
                    if (num < 0)
                    {
                        throw new MyException();
                    }

                    Console.WriteLine(num);
                }
                catch(MyException pe)
                {
                    Console.WriteLine(pe.Message);
                    return;
                }
                 
            }
        }
    }
}
