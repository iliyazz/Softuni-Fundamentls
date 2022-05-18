using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dragon> dragons = new List<Dragon>();
            List<string> dragonTypeInputOrder = new List<string>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] inputs = Console
                    .ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string type = inputs[0];
                string name = inputs[1];
                int damage = 0;
                int health = 0;
                int armor = 0;
                const int defaultDamage = 45;
                const int defaultHealth = 250;
                const int defaulArmor = 10;
                if (inputs[2] == "null")
                {
                    damage = defaultDamage;
                }
                else
                {
                    damage = int.Parse(inputs[2]);
                }
                if (inputs[3] == "null")
                {
                    health = defaultHealth;
                }
                else
                {
                    health = int.Parse(inputs[3]);
                }
                if (inputs[4] == "null")
                {
                    armor = defaulArmor;
                }
                else
                {
                    armor = int.Parse(inputs[4]);
                }

                if (dragons.Find(x => x.Type == type && x.Name == name) == null)
                {
                    Dragon dragon = new Dragon(type, name, damage, health, armor);
                    dragons.Add(dragon);
                    if (!dragonTypeInputOrder.Contains(type))
                    {
                        dragonTypeInputOrder.Add(type);
                    }
                }
                else if (dragons.Find(x => x.Type == type) == null  & dragons.Find(x => x.Name != name) == null)
                {
                    Dragon dragon = new Dragon(type, name, damage, health, armor);
                    dragons.Add(dragon);
                    if (!dragonTypeInputOrder.Contains(type))
                    {
                        dragonTypeInputOrder.Add(type);
                    }

                }
                else if (dragons.Find(x => x.Type == type) != null  & dragons.Find(x => x.Name == name) == null)
                {
                    Dragon dragon = new Dragon(type, name, damage, health, armor);
                    dragons.Add(dragon);

                }
                else if (dragons.Find(x => x.Type == type & x.Name == name) != null)
                {
                    int indexDragonExist = dragons.FindIndex(x => x.Type == type & x.Name == name);
                    dragons[indexDragonExist].Damage = damage;
                    dragons[indexDragonExist].Health = health;
                    dragons[indexDragonExist].Armor = armor;
                }
            }


            foreach (var item in dragonTypeInputOrder)
            {
                double averageDamage = dragons.Where(x => x.Type == item).Average(x => x.Damage);
                double averageHealth = dragons.Where(x => x.Type == item).Average(x => x.Health);
                double averageArmor = dragons.Where(x => x.Type == item).Average(x => x.Armor);
                Console.WriteLine($"{item}::({averageDamage:F2}/{averageHealth:F2}/{averageArmor:F2})");
                foreach (var item2 in dragons.Where(x => x.Type == item)
                    .OrderBy(x => x.Name))
                {
                    Console.WriteLine($"-{item2.Name} -> damage: {item2.Damage}, health: {item2.Health}, armor: {item2.Armor}");
                }
            }

        }
    }

    class Dragon
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }

        public Dragon(string type, string name, int damage, int health, int armor)
        {
            this.Type = type;
            this.Name = name;
            this.Damage = damage;
            this.Health = health;
            this.Armor = armor;

        }
    }
}
