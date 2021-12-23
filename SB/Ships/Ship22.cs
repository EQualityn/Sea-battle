using SB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB.Ships
{
    public class Ship22 : Ship, IFeaturable
    {
        public Ship22( int Id, bool Rotation, int X_coo, int Y_coo) : base(Id, Rotation, X_coo, Y_coo, "Bunker")
        {
        }
        public void Feature(Table table, int x, int y)
        {
            
            table.Shoot(x, y);
            featureRealised = true;
        }
    }
}
