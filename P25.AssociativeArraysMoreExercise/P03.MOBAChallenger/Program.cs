using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.MOBAChallenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, PlayerPosition> players = new Dictionary<string, PlayerPosition>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Season end")
            {
                string[] inputType = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (inputType[1] == "->")
                {
                    GetPlaeyrInfo(players, command);
                }
                else
                {
                    GetDuelInfo(players, command);

                }
            }
            PrintResult(players);
        }
        public static void PrintResult(Dictionary<string, PlayerPosition> players)
        {
            Dictionary<string, int> infoPlayer = new Dictionary<string, int>();
            PlayerPosition currentPlayer = new PlayerPosition(infoPlayer);


            foreach (KeyValuePair<string, PlayerPosition> item in players.OrderByDescending(x => x.Value.PlayerSumPoints).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {players[item.Key].PlayerSumPoints} skill");
                

                foreach (KeyValuePair<string, int> position in item
                    .Value
                    .InfoPlayer
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
        public static void GetPlaeyrInfo(Dictionary<string, PlayerPosition> players, string command)
        {
            string[] token = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string name = token[0];
            string position = token[1];
            int points = int.Parse(token[2]);
            Dictionary<string, int> infoPlayer = new Dictionary<string, int>();
            PlayerPosition currentPlayer = new PlayerPosition(infoPlayer);
            currentPlayer.InfoPlayer[position] = points;
            if (!players.ContainsKey(name))
            {
                players.Add(name, currentPlayer);
            }
            else if(!players[name].InfoPlayer.ContainsKey(position))
            {
                players[name].InfoPlayer.Add(position, points);
            }
            else if (players[name].InfoPlayer[position] < points)
            {
                players[name].InfoPlayer[position] = points;
            }

        }
        public static void GetDuelInfo(Dictionary<string, PlayerPosition> players, string command)
        {
            string[] token = command.Split(" vs ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string player1Name = token[0];
            string player2Name = token[1];
            PlayerPosition player1;
            PlayerPosition player2;
            if (!(players.ContainsKey(player1Name) && players.ContainsKey(player2Name)))
            {
                return;
            }
            player1 = players[player1Name];
            player2 = players[player2Name];

            string playerForRemove = String.Empty;
            foreach (var item in player1.InfoPlayer.Keys)
            {
                if (player2.InfoPlayer.ContainsKey(item))
                {
                    if (player1.InfoPlayer[item] > player2.InfoPlayer[item])
                    {
                        
                        playerForRemove = player2Name;
                    }
                    else if (player1.InfoPlayer[item] < player2.InfoPlayer[item])
                    {
                        playerForRemove = player1Name;
                        players.Remove(player1Name);
                    }
                }
            }
            if (playerForRemove != string.Empty)
            {
                players.Remove(playerForRemove);
            }
        }
    }
    class PlayerPosition 
    {
        public PlayerPosition(Dictionary<string, int> infoPlayer)
        {
            this.InfoPlayer = infoPlayer;
        }

        public Dictionary<string, int> InfoPlayer { get; set; }
        public int PlayerSumPoints
        { get
            {
                return InfoPlayer.Values.Sum();
            }
        }
    }
}
