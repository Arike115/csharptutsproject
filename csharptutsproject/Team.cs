using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptutsproject
{
    public class Team
    {
        public void TeamPlayer()
        {
            List<Player> teams = new List<Player>()
            {
                new Player(){Name = "john", Age = 45},
                new Player(){Name = "ben", Age = 35},
                new Player(){Name = "mary", Age = 25},
                new Player(){Name = "joseph", Age = 15},
            };

            var details = teams.Where(n => n.Age == 15);


            foreach(var result in details)
            {
                Console.WriteLine("Name is {0} and i am {1} years old", result.Name, result.Age);
            }
        }

       


        //public Player[] playerteam = new Player[4];
        //public Team()
        //{
        //    playerteam[0] = new Player("virat", 24);
        //    playerteam[0] = new Player("ben", 20);
        //    playerteam[0] = new Player("John",35);
        //    playerteam[0] = new Player("mary", 19);
        //}
    }
}
