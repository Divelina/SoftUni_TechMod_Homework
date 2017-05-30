using System;

namespace Hotel
{
    public class Hotel
    {
        public static void Main()
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            var pricePerNight = new double[] { 0, 0, 0};
            var totalPrice = new double[] { 0, 0, 0 };

            //setting the pricesPerNight
            //indexes: 0-studio, 1-double, 2-suite

            switch (month)
            {
                case "May":
                case "October":
                    {
                        pricePerNight[0] = 50;
                        pricePerNight[1] = 65;
                        pricePerNight[2] = 75;
                        if (nights > 7)
                        {
                            pricePerNight[0] *= 0.95;
                        }
                    } break;

                case "June":
                case "September":
                    {
                        pricePerNight[0] = 60;
                        pricePerNight[1] = 72;
                        pricePerNight[2] = 82;
                        if (nights > 14)
                        {
                            pricePerNight[1] *= 0.9;
                        }
                    } break;
                case "July":
                case "August":
                case "December":
                    {
                        pricePerNight[0] = 68;
                        pricePerNight[1] = 77;
                        pricePerNight[2] = 89;
                        if (nights > 14)
                        {
                            pricePerNight[2] *= 0.85;
                        }
                    }  break;
            }

            for (int i = 0; i <= 2; i++)
            {
                totalPrice[i] = nights * pricePerNight[i];
            }

            if ((month == "September" || month == "October") && (nights > 7))
            {
                totalPrice[0] -= pricePerNight[0];   
            }

            Console.WriteLine($"Studio: {totalPrice[0]:F2} lv.");
            Console.WriteLine($"Double: {totalPrice[1]:F2} lv.");
            Console.WriteLine($"Suite: {totalPrice[2]:F2} lv.");
        }
    }
}
