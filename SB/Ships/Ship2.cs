using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SB.Ships;

namespace SB.Ships
{
    public class Ship2 : Ship
    {
        public Ship2(int Id, bool Rotation, int X_coo, int Y_coo) : base(Id, Rotation, X_coo, Y_coo, "Destroyer")
        {
        }
    }
}