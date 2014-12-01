using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Times.Time
{
    public class Team
    {
        public List<Player> Players { get; set; }

        public Team ()
        {
            this.Players = new List<Player>();
        }

        // Pick up the player with the highest hability available for the team
        public void GetBestPlayer(List<Player> playersAvailable)
        {
            int bestID = 0;

            for (int i = 1; i < playersAvailable.Count; i++)
                if (playersAvailable[i].Hability > playersAvailable[bestID].Hability)
                    bestID = i;

            this.Players.Add(playersAvailable[bestID]);
            playersAvailable.RemoveAt(bestID);
        }

        // Show the players setted in that team
        public string ShowPlayers()
        {
            string playersName = null;

            foreach (Player player in this.Players)
            {
                playersName += player.Name + "\r\n";
            }

            return playersName;
        }
    }
}
