using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Times.Time;

namespace Times
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lineInput = new String[2];
            int i, nPlayers, nTeams;
            List<Team> Teams = new List<Team> ();
            List<Player> Players = new List<Player>();

            // Read input - nah, ain't nobody got time for exception handling for now
            lineInput = Console.ReadLine().Split(' ');
            nPlayers = Int32.Parse(lineInput[0]);
            nTeams = Int32.Parse(lineInput[1]);

            // Create the teams instances
            for (i = 0; i < nTeams; i++)
                Teams.Add(new Team());

            // And now add the players
            while (nPlayers-- > 0)
            {
                lineInput = Console.ReadLine().Split(' ');
                Players.Add(new Player(lineInput[0], Int32.Parse(lineInput[1])));
            }

            // While there are still players to be placed in teams, add them
            while (Players.Count != 0)
            {
                for (i = 0; i < nTeams && Players.Count != 0; i++)
                    Teams[i].GetBestPlayer(Players);
            }

            // Show the players assigned in each team
            for (i = 0; i < nTeams && Players != null; i++)
                Console.WriteLine("Time " + (i + 1) + " \r\n" + Teams[i].ShowPlayers() + "\r\n");

            // Exit
            Console.ReadKey();
        }
    }
}
