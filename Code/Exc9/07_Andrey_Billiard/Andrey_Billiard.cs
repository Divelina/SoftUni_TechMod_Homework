using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_Andrey_Billiard
{
    public class Client
    {
        public string Name { get; set; }
        public Dictionary<string, int> Purchase { get; set; }
    }

    public class Andrey_Billiard
    {
        public static void Main()
        {
            var productsNum = int.Parse(Console.ReadLine());

            var productPrice = new Dictionary<string, double>();

            for (int i = 1; i <= productsNum; i++)
            {
                var product = Console.ReadLine().Split('-').ToArray();

                var productName = product[0];
                var price = double.Parse(product[1]);

                productPrice[productName] = price;
            }

            var clients = Console.ReadLine();
            var clientList = new List<Client>();

            while (clients != "end of clients")
            {
                var nextClient = clients
                    .Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var clientName = nextClient[0];
                var purchase = nextClient[1];
                var quantity = int.Parse(nextClient[2]);

                if (productPrice.ContainsKey(purchase))
                {
                    var newClient = new Client();

                    if (clientList.Where(cl => cl.Name == clientName).Count() == 0)
                    {
                        newClient = CreateNewClient(clientName);
                        clientList.Add(newClient);
                    }
                    
                    if (!clientList.Find(cl => cl.Name == clientName).Purchase.ContainsKey(purchase))
                    {
                        clientList.Find(cl => cl.Name == clientName).Purchase[purchase] = 0;
                    }

                    clientList.Find(cl => cl.Name == clientName).Purchase[purchase] += quantity;
                }
                
                clients = Console.ReadLine();
            }

            clientList = clientList.OrderBy(cl => cl.Name).ToList();

            var totalBill = 0.0;

            foreach (var person in clientList)
            {
                Console.WriteLine(person.Name);

                var bill = 0.0;

                foreach (var item in person.Purchase)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");

                    bill += item.Value * productPrice[item.Key];
                }
                
                totalBill += bill;
                Console.WriteLine($"Bill: {bill:F2}");
            }

            Console.WriteLine($"Total bill: {totalBill:F2}");
        }

        public static Client CreateNewClient(string clientName)
        {
            var newClient = new Client
            {
                Name = clientName,
                Purchase = new Dictionary<string, int>()
            };

            return newClient;
        }
    }
}

