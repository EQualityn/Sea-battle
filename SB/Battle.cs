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

        
       public Battle() { }
        public void BattleInit ()
        {
            player.table.AutoDisposal();
            engine.table.AutoDisposal();
            //Console.WriteLine("Player's table");
            //player.table.ShowTable();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Engine's table");
            //engine.table.ShowTable();

            Table table = player.table;
            player.table = engine.GetTable();
            engine.table = table;
           
            //swap tables for battle, so player.table is actually appeals to engine's table and vice versa.
           
            
        }
        public void BattleStart()
        {

            Console.WriteLine("Player table");
            engine.table.ShowTable();
            Console.WriteLine("Engine table");
            player.table.ShowTable();
            Console.WriteLine();
            Console.WriteLine();
            //while (player.PlayerTable.CheckAlive() && engine.EngineTable.CheckAlive())
            //{
            string difficultyMode = string.Empty;
            difficultyMode = "medium"; // easy
            Console.WriteLine("Enter amount of turns");
            int turns = Convert.ToInt32(Console.ReadLine()); 
            while (Convert.ToBoolean(turns))
            {
                //фича
               
                player.Turn("manual");
                engine.Turn(difficultyMode);
                //Console.WriteLine("Player table");
                //engine.table.ShowTable();
                Console.WriteLine();
                Console.WriteLine();
                //Console.WriteLine("Engine table");
                //player.table.ShowTable();
                Console.WriteLine();
                Console.WriteLine();
                turns--;
                
            }

            //}
        }
    }
}
