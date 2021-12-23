using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SB.Interfaces;
using SB.Ships;

namespace SB.Ships
{
    public class Ship1 : Ship, IFeaturable
    {

        public Ship1(int Id, bool Rotation, int X_coo, int Y_coo) : base(Id, Rotation, X_coo, Y_coo, "Corvette")
        {

        }
        public void Feature(Table table, int x, int y)
        {
            
            if (table[x,y] == 0)
            {
                table[this.X_coo, this.Y_coo] = 0;
                table[x,y] = this.Id;
                this.X_coo = y;
                this.Y_coo = x;
            }
            else
            {
                //You can't move here
            }
        }
    }
}
