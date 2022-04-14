using System;
using System.Collections.Generic;
using System.Linq;

namespace P02OldestFamilyMember_2
{
    public class Person
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

    public class Family
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
            var oldestmember = new Person { Name = "one", Age = -1 };
            foreach (var kvp in PersonList)
            {
                if (oldestmember.Age < kvp.Age)
                {
                    oldestmember = kvp;
                }
            } // end foreach

            Console.WriteLine("{0} {1}", oldestmember.Name, oldestmember.Age);
        }

    } // end class Family
    internal class Program
    {
        public static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            Family familyPersons = new Family();

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split();

                Person current = new Person(tokens[0], int.Parse(tokens[1]));

                familyPersons.AddMember(current);
            } // end for

            if (familyPersons.PersonList.Count > 0)
            {
                familyPersons.GetOldestMember();
            }

        }
    }

}
