using SB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB.Ships
{
    public class Ship5 : Ship, IFeaturable
    {
        public Ship5(int Id, bool Rotation, int X_coo, int Y_coo) : base(Id, Rotation, X_coo, Y_coo,"Carrier")
        {
        }
        public void Feature(Table table, int line, int rotate)
        { 
           

            for (int i = 0; i < 15; i++)
            {
                table.Shoot(i, line);
                featureRealised = true;
            }
        }
    }
}
