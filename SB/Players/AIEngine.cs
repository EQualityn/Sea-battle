using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB
{
   public class AIEngine : BasePlayer
    {
        public AIEngine()
        {
        }
        
        public override void ShootStrategy(string difficulty)
        {   
            Random rnd = new Random();
            int x, y;
            switch (difficulty){
                case "easy":
                    do
                    {
                        x = rnd.Next(0, 14);
                        y = rnd.Next(0, 14);
                        table.Shoot(x, y);
                        Console.WriteLine($"Engine shot at {x}, {y}");
                        Console.WriteLine();
                        table.ShowTable();
                        Console.WriteLine();
                    } while (table.lastSuccessShot);
                    break;
                case "medium":
                   // bool isHit = false;
                    // table isSunk = true;
                    // isSunk = false if ship.alivecells!=0;
                    // while isSunk (Shoot.Rand)
                    // while !isSunk =>ShootClever(Shoot while isHit);

                    x = rnd.Next(0, 14);
                    y = rnd.Next(0, 14);

                    if (table.lastSuccessShot)
                    // switch rotation
                    {
                        int x_hit = x;
                        int y_hit = y;
                        if (x_hit < 14)
                        {
                            table.Shoot(x + 1, y);
                        }
                        if (y_hit < 14)
                        {
                            table.Shoot(x, y + 1);
                        }
                        if (y_hit > 0)
                        {
                            table.Shoot(x - 1, y);
                        }
                        if (x_hit > 0)
                        {
                            table.Shoot(x, y - 1);
                        }
                    }

                    table.Shoot(x, y);
                    break;

                case "hard":
                   
                    break;


            }
            
        }
      

    }
}
