using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> inputContestAndPass = new Dictionary<string, string>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end of contests")
            {
                string[] token = command
                    .Split(':')
                    .ToArray();
                inputContestAndPass[token[0]] = token[1];
            }
            //The Key is username
            SortedDictionary<string, Person> people = new SortedDictionary<string, Person>();
            string command2 = string.Empty;

            while ((command2 = Console.ReadLine()) != "end of submissions")
            {
                string[] token = command2.Split("=>").ToArray();
                string contestCurr = token[0];
                string passwordCurr = token[1];
                string userNameCurr = token[2];
                int pointsCurr = int.Parse(token[3]);
                Dictionary<string, int> contextAndPoint = new Dictionary<string, int>();
                Person currentPerson = new Person(contextAndPoint); 
                currentPerson.InfoPerson[contestCurr] = pointsCurr;

                if (inputContestAndPass.ContainsKey(contestCurr) && (inputContestAndPass[contestCurr] == passwordCurr))
                {
                    if(!people.ContainsKey(userNameCurr))
                    {
                        people[userNameCurr] = currentPerson;
                    }
                    else if (!people[userNameCurr].InfoPerson.ContainsKey(contestCurr))
                    {
                        people[userNameCurr].InfoPerson[contestCurr] = pointsCurr;
                    }
                    else if (people[userNameCurr].InfoPerson[contestCurr] < pointsCurr)
                    {
                        people[userNameCurr].InfoPerson[contestCurr] = pointsCurr;
                    }
                }
            }
            Bestcandidate(people);

            Console.WriteLine("Ranking: ");
            foreach (KeyValuePair<string, Person> item in people)
            {
                Console.WriteLine(item.Key);
                foreach (var item2 in item.Value.InfoPerson.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item2.Key} -> {item2.Value}");
                }
            }
        }
        public static void Bestcandidate(SortedDictionary<string, Person> people)
        {
            int maxSum = 0;
            string bestCandidate = string.Empty;
            Dictionary<string, int> contextAndPoint = new Dictionary<string, int>();
            Person currentPerson = new Person(contextAndPoint);
            foreach (KeyValuePair<string, Person> itemPerson in people)
            {
                int currSum = 0;
                foreach (var item in itemPerson.Value.InfoPerson.Values)
                {
                    currSum += item;
                }
                if (currSum > maxSum)
                {
                    maxSum = currSum;
                    bestCandidate = itemPerson.Key;
                }
            }
            Console.WriteLine($"Best candidate is {bestCandidate} with total {maxSum} points.");
        }
    }
    class Person
    {
        public Person(Dictionary<string, int> infoPerson) 
        {
            this.InfoPerson = infoPerson;
        }
        public Dictionary<string, int> InfoPerson { get; set; }

    }
}
