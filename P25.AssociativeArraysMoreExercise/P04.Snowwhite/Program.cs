using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dwarf> dwarfs = new List<Dwarf>();
            GetDwarfInfo(dwarfs);
        }
        public static void GetDwarfInfo(List<Dwarf> dwarfs)
        {
            string dwarfCmd = string.Empty;
            while ((dwarfCmd = Console.ReadLine()) != "Once upon a time")
            {
                string[] token = dwarfCmd.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string dwarfName = token[0];
                string dwarfHatColor = token[1];
                long dwarfPhysics = long.Parse(token[2]);
                Dwarf currentDwarf = new Dwarf(dwarfName, dwarfHatColor, dwarfPhysics);
                if (!dwarfs.Any(x => x.Name.Contains(dwarfName) || x.Color.Contains(dwarfHatColor)))
                {
                    dwarfs.Add(currentDwarf);
                }
                else if(dwarfs.Any(x => x.Name.Contains(dwarfName) & x.Color.Contains(dwarfHatColor)))
                {
                    Dwarf existing = dwarfs.Find(x => x.Name == dwarfName && x.Color == dwarfHatColor);
                    if (existing.Physics < dwarfPhysics)
                    {
                        existing.Physics = dwarfPhysics;
                    }
                }

            }
            foreach (var item in dwarfs.OrderByDescending(x => x.Physics).ThenByDescending( x => dwarfs.Count(y => y.Color & x.Color)
            {
                Console.WriteLine();
            }

        }
    }
    class Dwarf
    {
        public Dwarf(string name, string color, long physics)
        {
            this.Name = name;
            this.Color = color;
            this.Physics = physics;
        }
        public string Name { get; set; }
        public string Color { get; set; }
        public long Physics { get; set; }


    }

}
