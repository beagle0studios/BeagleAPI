using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc
{
    public class Indexing_D
    {
        Team teamus = new Team();

        public Indexing_D(int amount, string[] names, int[] ages)
        {
            Team.amount = amount;
            teamus[0] = new Player { Name = "Ben", Age = 21 };
            teamus[1] = new Player { Name = "Riu", Age = 16 };
        }

        public string GetPlayerNameAtIndex(int index)
        {
            return teamus[index].Name;
        }

        public int GetPlayerAgeAtIndex(int index)
        {
            return teamus[index].Age;
        }
    }

    public class Team
    {
        public static int amount = 25;

        private Player[] team = new Player[amount];

        public Player this[int index]
        {
            get { return team[index]; }
            set
            {
                if (team[index] == null)
                    team[index] = value;
                else
                    for (int i = 0; i < amount; i++)
                        if (team[i] == null)
                        {
                            team[i] = value;
                            return;
                        }
            }
        }
    }

    public class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
