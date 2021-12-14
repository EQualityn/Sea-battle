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
            switch (difficulty){
                case "easy":
                    
                   int x_es = rnd.Next(0, 14);
                   int y_es = rnd.Next(0, 14);
                    table.Shoot(y_es,x_es);
                    break;

                case "medium":
                    // table isSunk = true;
                    // isSunk = false if ship.alivecells!=0;
                    // while isSunk (Shoot.Rand)
                    // while !isSunk =>ShootClever(Shoot while isHit);
                    int x_m = rnd.Next(0, 14);
                    int y_m = rnd.Next(0, 14);
                    
                    table.Shoot(x_m, y_m);
                    if (table.isHit)
                        // switch rotation
                    {
                        int x_hit = x_m;
                        int y_hit = y_m;
                        if (x_hit < 14)
                        {
                            table.Shoot(x_m + 1, y_m);
                        }
                        if (y_hit < 14)
                        {
                            table.Shoot(x_m, y_m+1);
                        }
                        if (y_hit > 0)
                        {
                            table.Shoot(x_m-1, y_m);
                        }
                        if (x_hit > 0)
                        {
                            table.Shoot(x_m, y_m-1);
                        }
                    }
                   // if ()
                    break;

                case "hard":
                   
                    break;


            }
            
        }
      

    }
}
