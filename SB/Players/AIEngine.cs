using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB
{
   public class AIEngine : BasePlayer
    {
        public static bool lastSuccessShot = false;
        public AIEngine()
        {
        }
        
        public override void ShootStrategy(string difficulty)
        {   
            Random rnd = new Random();
            switch (difficulty){
                case "easy":
                    
                   int x = rnd.Next(0, 14);
                   int y = rnd.Next(0, 14);
                    table.Shoot(x,y);
                    break;

                case "medium":
                   // bool isHit = false;
                    // table isSunk = true;
                    // isSunk = false if ship.alivecells!=0;
                    // while isSunk (Shoot.Rand)
                    // while !isSunk =>ShootClever(Shoot while isHit);
                    x = rnd.Next(0, 14);
                    y = rnd.Next(0, 14);
                    
                    table.Shoot(x, y);
                    //
                    if (lastSuccessShot)
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
                            table.Shoot(x, y+1);
                        }
                        if (y_hit > 0)
                        {
                            table.Shoot(x-1, y);
                        }
                        if (x_hit > 0)
                        {
                            table.Shoot(x, y-1);
                        }
                    }
                   // if (isSunk)
                  
                   // if ()
                    break;

                case "hard":
                   
                    break;


            }
            
        }
      

    }
}
