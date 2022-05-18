namespace Ranking
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> inputContestAndPass = new Dictionary<string, string>();

            string command = "";

            while ((command = Console.ReadLine()) != "end of contests")
            {
                string[] token = command.Split(':');

                string contest = token[0];
                string password = token[1];

                inputContestAndPass[contest] = password;
            }

            var contestDict = new Dictionary<string, Dictionary<string, int>>();

            string command2 = "";

            while ((command2 = Console.ReadLine()) != "end of submissions")
            {
                string[] token = command2.Split("=>");

                string contestCurr = token[0];
                string passwordCurr = token[1];
                string userNameCurr = token[2];
                int pointsCurr = int.Parse(token[3]);

                if (inputContestAndPass.ContainsKey(contestCurr) && inputContestAndPass[contestCurr] == passwordCurr)
                {
                    if (!contestDict.ContainsKey(userNameCurr))
                    {
                        contestDict[userNameCurr] = new Dictionary<string, int>();
                    }

                    if (contestDict.ContainsKey(userNameCurr) && !contestDict[userNameCurr].ContainsKey(contestCurr))
                    {
                        contestDict[userNameCurr][contestCurr] = 0;
                    }

                    if (contestDict[userNameCurr][contestCurr] < pointsCurr)
                    {
                        contestDict[userNameCurr][contestCurr] = pointsCurr;
                    }
                }
            }

            string winner = contestDict.OrderBy(x => x.Value.Values.Sum()).Last().Key;
            int bestPoints = contestDict.OrderBy(x => x.Value.Values.Sum()).Last().Value.Values.Sum();

            Console.WriteLine($"Best candidate is {winner} with total {bestPoints} points.");

            Console.WriteLine("Ranking:");

            foreach (var item in contestDict.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var contest in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
