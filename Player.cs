using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Queues_Thompson_Lillian
{
    internal class Player
    { 
        public int Health { get; set; }

        public string GamerTag { get; } 

        public Player(int healthParam, string nameParam)
        {
            Health = healthParam;
            GameTag = nameParam;
        }

        public void JoinGame(Game game, Queue<Player>)
        {
            if (game.CurrentPlayers == game.MaxPlayers)
            {
                Queue.Enqueue(this);
            }
            else
            {
                Console.WriteLine("Joining Game!!");
                game.CurrentPlayers++;
            }
            
                public override string ToString()
        {
            return GamerTag;
        }
        

       
         }
    }
}
