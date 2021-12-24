using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB
{
    public class Player : BasePlayer
    {
 
      
        public Player()
        {
        }

       //ShootStrategy = Turn()
        public override void Turn(string difficultyMode)
        {
            GlobalVariablesForGame.Turn = true;
            do
            {
                Console.WriteLine("Enter key for player's feature");
                int key = int.Parse(Console.ReadLine());
                table.ChooseFeature(key);
                Console.WriteLine("Enter x and y to shoot at");
                var coords = Console.ReadLine().Split();
                table.Shoot(int.Parse(coords[0]), int.Parse(coords[1])); // or y,x?
                Console.WriteLine($"Player shot at {coords[0]}, {coords[1]}");
                Console.WriteLine();
                table.ShowTable();
                Console.WriteLine();
            } while (table.shootAgain);


        }
       

    }
}
