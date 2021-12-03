using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SB.Ships;

namespace SB.Ships
{
    public class Ship1 : Ship, IFeaturable
    {
        
            public Ship1(int Id, bool Rotation, int X_coord, int Y_coord) : base(Id, Rotation, X_coord, Y_coord)
            {
                this.Id = Id;
                Name = "Corvette";
                this.Rotation = Rotation;
                this.Y_coord = Y_coord;
                this.X_coord = X_coord;
            }
        public void Feature(Table table, int x, int y)
        {
            if (table[x, y] == 0)
            {
                table[this.X_coord, this.Y_coord] = 0;
                table[x, y] = this.Id;
                this.X_coord = x;
                this.Y_coord = y;
            }
            else
            {
                //You can't move here
            }
        }
    }
}
