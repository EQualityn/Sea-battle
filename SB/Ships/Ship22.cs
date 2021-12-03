using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB.Ships
{
    public class Ship22 : Ship
    {
        public Ship22( int Id, bool Rotation, int X_coord, int Y_coord) : base("Bunker",Id, Rotation, X_coord, Y_coord)
        {
            this.Id = Id;
            Name = "Bunker";
            this.Rotation = Rotation;
            this.Y_coord = Y_coord;
            this.X_coord = X_coord;
        }
    }
}
