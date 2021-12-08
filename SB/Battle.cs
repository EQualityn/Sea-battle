using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB
{
    public class Battle
    {
        Player player = new Player();
        AIEngine engine = new AIEngine();
        //public Player player = new Player();
        //public AIEngine engine = new AIEngine();
       public Battle() { }
        public void BattleInit ()
        {
            player.PlayerTable.AutoDisposal();
            engine.EngineTable.AutoDisposal();
            Console.WriteLine("Player's table");
            player.PlayerTable.ShowTable();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Engine's table");
            engine.EngineTable.ShowTable();
            Table table = player.PlayerTable;
            player.PlayerTable = engine.GetTable();
            engine.EngineTable = table;
            //swap table
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        public void BattleStart()
        {
            
                Console.WriteLine("Player's(Engine) table");
                player.PlayerTable.ShowTable();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Engine's(Player) table");
                engine.EngineTable.ShowTable();
            Console.WriteLine();
            Console.WriteLine();
            //while (player.PlayerTable.CheckAlive() && engine.EngineTable.CheckAlive())
            //{
            player.ShootStrategy();
            //}
        }
    }
}
