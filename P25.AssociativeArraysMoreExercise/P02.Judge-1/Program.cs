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
                else if (people[username].InfoPerson[contest] < points)
                {
                    people[username].InfoPerson[contest] = points;
                }
            }
            Printresult(people, inputOrderContest);
        }
        public static void Printresult(Dictionary<string, Person> people, List<string> inputOrderContest)
        {
            //Dictionary<string, Person> peopleOrdered = new Dictionary<string, Person>(people);



            foreach (var contest in inputOrderContest)
            {
                Console.WriteLine($"{contest}: {people.Where(x => x.Value.InfoPerson.ContainsKey(contest)).Count()} participants");
                int count = 0;
                Dictionary<string, Person> peopleOrdered = new Dictionary<string, Person>();
                foreach (var item in people)
                {
                    if (item.Value.InfoPerson.ContainsKey(contest))
                    {
                        peopleOrdered[item];
                    }
                }





                foreach (KeyValuePair<string, Person> infoPeople in peopleOrdered.Where(x => x.Value.InfoPerson.ContainsKey(contest)).OrderByDescending(y => y.Value.InfoPerson.Values))
                //foreach (KeyValuePair<string, Person> infoPeople in people.Where(x => x.Value.InfoPerson.ContainsKey(contest)))

                //foreach (KeyValuePair<string, Person> infoPeople in people.Where(x => x.Value.InfoPerson.ContainsKey(contest)).OrderByDescending(y => y.Value.InfoPerson.Values))
                {
                    count++;
                    Console.WriteLine($"{count}. {infoPeople.Key} <::> {people[infoPeople.Key].InfoPerson[contest]}");
                    Console.WriteLine($"{count}. {infoPeople.Key} <::> {people[infoPeople.Key].InfoPerson[contest]}");



                }




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
        //public int InfoPersonSumPoints { get; set; }
        public int InfoPersonSumPoints
        {
            get
            {
                return InfoPerson.Values.Sum();
            }


        }

    }

}
