using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB.Ships
{
    public class Ship5 : Ship
    {
        public Ship5(int Id, bool Rotation, int X_coord, int Y_coord) : base(Id, Rotation, X_coord, Y_coord)
        {
            this.Id = Id;
            Name = "Carrier";
            this.Rotation = Rotation;
            this.Y_coord = Y_coord;
            this.X_coord = X_coord;
        }
    }
}
