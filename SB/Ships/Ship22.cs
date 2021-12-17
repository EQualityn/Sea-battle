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
        public Ship22( int Id, bool Rotation, int X_coord, int Y_coord) : base(Id, Rotation, X_coord, Y_coord, "Bunker")
        {
        }
        public void Feature(Table table)
        {
            Console.WriteLine("Double shot x and y:");
            string[] coords = Console.ReadLine().Split();
            table.Shoot(int.Parse(coords[0]), int.Parse(coords[1]));
            featureRealised = true;
        }
    }
}
