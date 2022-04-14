using System;
using System.Collections.Generic;
using System.Linq;

namespace P02OldestFamilyMember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            Family familyPersons = new Family();

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                Person current = new Person(name, age);
                familyPersons.AddMember(current);
            }
            familyPersons.GetOldestMember();
        }
    }
    class Person
    {
        public Person() { }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }
    }

    class Family
    {
        public Family()
        {
            this.PersonList = new List<Person>();
        }
        public List<Person> PersonList { get; set; }

        public void AddMember(Person member)
        {

            PersonList.Add(member);
        }

        public void GetOldestMember()
        {
            Person oldestmember = PersonList.OrderByDescending(x => x.Age).FirstOrDefault();

            if (oldestmember != null)
            {
                Console.WriteLine($"{oldestmember.Name} {oldestmember.Age}");
            }
        }
    }

}
