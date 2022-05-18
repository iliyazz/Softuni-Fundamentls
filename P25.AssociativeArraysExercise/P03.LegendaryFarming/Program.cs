using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.LegendaryFarming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputStr = Console.ReadLine().ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] materials = new string[] { "shards", "fragments", "motes" };
            Dictionary<string, int> farming = new Dictionary<string, int>();
            farming.Add("shards", 0);
            farming.Add("motes", 0);
            farming.Add("fragments", 0);
            bool isPrinting = false;
            while (true)
            {
                for (int i = 0; i < inputStr.Length; i += 2)
                {
                    int tokenInt = int.Parse(inputStr[i]);
                    string tokenStr = inputStr[i + 1];
                    if (materials.Contains(tokenStr))
                    {
                        CheckItem(farming, tokenStr, tokenInt, ref isPrinting);
                        if (isPrinting == true)
                        {
                            break;
                        }
                    }
                    else
                    {
                        CheckJunk(farming, tokenStr, tokenInt);
                    }
                }
                if (isPrinting == true)
                {
                    break;
                }
                inputStr = Console.ReadLine().ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
        }

        public static void CheckJunk(Dictionary<string, int> farming, string tokenStr, int tokenInt)
        {
            if (farming.ContainsKey(tokenStr))
            {
                farming[tokenStr] += tokenInt;
            }
            else
            {
                farming.Add(tokenStr, tokenInt);
            }
        }

        public static void CheckItem(Dictionary<string, int> farming, string tokenStr, int tokenInt, ref  bool isPrinting)
        {
            if (farming.ContainsKey(tokenStr))
            {
                farming[tokenStr] += tokenInt;
            }
            else
            {
                farming.Add(tokenStr, tokenInt);
            }
            if (farming[tokenStr] >= 250)
            {
                farming[tokenStr] -= 250;
                string legendaryItem = string.Empty;
                if (tokenStr == "shards")
                {
                    legendaryItem = "Shadowmourne";
                }
                else if (tokenStr == "fragments")
                {
                    legendaryItem = "Valanyr";
                }
                else if (tokenStr == "motes")
                {
                    legendaryItem = "Dragonwrath";
                }
                Console.WriteLine($"{legendaryItem} obtained!");
                foreach (var item in farming)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
                isPrinting = true;
            }
        }
    }
}
