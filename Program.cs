namespace Queues_Thompson_Lillian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game(50, 49);

            Queue<Player> waitingToJoinQ = new Queue<Player>();

            Player p1 = new Player(100, "MMsix");
            Player p2 = new Player(100, "XxAwesomenessXx");
            Player p3 = new Player(100, "Get Good");
            Player p4 = new Player(100, "ZombieSlaya");

            p1.JoinGame(myGame, waitingToJoinQ);
            p2.JoinGame(myGame, waitingToJoinQ);
            p3.JoinGame(myGame, waitingToJoinQ);
            p4.JoinGame(myGame, waitingToJoinQ);

            Console.WriteLine("Player in DA Q:");
            foreach (Player player in waitingToJoinQ)
            {
                Console.WriteLine(player);
            }
            myGame.KickPlayer();
            myGame.CheckQueue(waitingToJoinQ);

            Console.WriteLine("/nPLayers in da q:");
            foreach(Player player in waitingToJoinQ)
            {
                Console.WriteLine(player);
            }
           

        }
    }
}