using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SB.Ships;

namespace SB.Ships
{
    public class Ship1 : Ship
    {
            public Ship1(string Name,int Id, bool Rotation, int X_coord, int Y_coord) : base("Corvette",Id, Rotation, X_coord, Y_coord)
            {
                this.Id = Id;
                this.Name = Name;
                this.Rotation = Rotation;
                this.Y_coord = Y_coord;
                this.X_coord = X_coord;
            }
        }
}
