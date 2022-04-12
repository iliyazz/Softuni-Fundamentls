using System;
using System.Collections.Generic;

namespace P03Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nubmerOfSongs = int.Parse(Console.ReadLine());
            List<Songs> songList = new List<Songs>();
            //while (command != "Type List" || command != "all")
            for (int i = 0; i < nubmerOfSongs; i++)
            {
                string[] cmdArg = Console.ReadLine().Split('_', StringSplitOptions.RemoveEmptyEntries);
                string type = cmdArg[0];
                string name = cmdArg[1];
                string time = cmdArg[2];
                
                Songs song = new Songs()
                {
                    TypeList = type,
                    Name = name,
                    Time = time
                };
                songList.Add(song);
                
            }

            string command = Console.ReadLine();
            if (command == "all")
            {
                foreach (Songs item in songList)
                {
                    Console.WriteLine(item.Name);
                }
            }
            
            else
            {
                List<Songs> filteredList = songList.FindAll(x => x.TypeList == command);
                foreach (Songs item in filteredList)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }

    class Songs
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
