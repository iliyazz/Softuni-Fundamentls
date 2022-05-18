using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> people = new Dictionary<string, Person>();
            List<string> inputOrderContest = new List<string>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "no more time")
            {
                string[] token = command
                    .Split(" -> ")
                    .ToArray();
                string username = token[0];
                string contest = token[1];
                int points = int.Parse(token[2]);
                if (!inputOrderContest.Contains(contest))
                {
                    inputOrderContest.Add(contest);
                }
                Dictionary<string, int> infoPerson = new Dictionary<string, int>();
                Person currentPerson = new Person(infoPerson);
                currentPerson.InfoPerson[contest] = points;
                if (!people.ContainsKey(username))
                {
                    people.Add(username, currentPerson);
                }
                else if (!people[username].InfoPerson.ContainsKey(contest))
                {
                    people[username].InfoPerson[contest] = points;
                }
                else if(people[username].InfoPerson[contest] < points)
                {
                    people[username].InfoPerson[contest] = points;
                }
            }
            Printresult(people, inputOrderContest);
        }
        public static void Printresult(Dictionary<string, Person> people, List<string> inputOrderContest)
        {
            int count = 0;
            foreach (var contest in inputOrderContest)
            {
                Console.WriteLine($"{contest}: {people.Where(x => x.Value.InfoPerson.ContainsKey(contest)).Count()} participants");
                count = 0;

                Dictionary<string, int> peopleOrdered = new Dictionary<string, int>();


                foreach (KeyValuePair<string, Person> infoPeople in people.Where(x => x.Value.InfoPerson.ContainsKey(contest)))
                {
                    string personNamwe = infoPeople.Key;
                    int personPoint = people[infoPeople.Key].InfoPerson[contest];
                    peopleOrdered.Add(personNamwe, personPoint);
                }
                foreach (var item in peopleOrdered.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    count++;
                    Console.WriteLine($"{count}. {item.Key} <::> {item.Value}");
                }

            }
                count = 0;
                Console.WriteLine("Individual standings:");
                foreach (KeyValuePair<string, Person> totalPoint in people.OrderByDescending(x => x.Value.InfoPersonSumPoints).ThenBy(x => x.Key))
                {
                    count++;

                Console.WriteLine($"{count}. {totalPoint.Key} -> {totalPoint.Value.InfoPersonSumPoints}");
            }
        }
    }
    class Person
    {
        public Person(Dictionary<string, int> infoPerson)
        {
            this.InfoPerson = infoPerson;
        }
        public Dictionary<string, int> InfoPerson { get; set; }
        public int InfoPersonSumPoints
        {
            get
            {
                return InfoPerson.Values.Sum();
            }
        }

    }

}
