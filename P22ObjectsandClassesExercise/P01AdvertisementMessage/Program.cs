using System;
using System.Collections.Generic;

namespace P01AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrasesStr = new[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] eventsStr = new[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] autorsStr = new[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] citiesStr = new[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            int numberOfMessages = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfMessages; i++)
            {
                List<string> advertisementMessage = new List<string>();
                randomMassage(phrasesStr, advertisementMessage);
                randomMassage(eventsStr, advertisementMessage);
                randomMassage(autorsStr, advertisementMessage);
                randomMassage(citiesStr, advertisementMessage);
            Console.WriteLine($"{advertisementMessage[0]} {advertisementMessage[1]} {advertisementMessage[2]} – {advertisementMessage[3]}.");
            }

         }

        static void randomMassage(string[] existingStr, List<string> advertisementMessage)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, existingStr.Length);
            advertisementMessage.Add(existingStr[randomIndex]);
        }
    }
}
