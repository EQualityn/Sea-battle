using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB.Ships
{
    public class Ship5 : Ship, IFeaturable
    {
        public Ship5(int Id, bool Rotation, int X_coord, int Y_coord) : base(Id, Rotation, X_coord, Y_coord,"Carrier")
        {
        }
        public void Feature(Table table, int x, int y)
        {
            for (int i = 0; i < 15; i++)
            {
                table[x, i] = 1;
            }
        }
    }
}
