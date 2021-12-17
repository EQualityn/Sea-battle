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

        public Ship1(int Id, bool Rotation, int X_coord, int Y_coord) : base(Id, Rotation, X_coord, Y_coord, "Corvette")
        {

        }
        public void Feature(Table table)
        {
            Console.WriteLine("Move to field:");
            string[] coords = Console.ReadLine().Split();
            if (table[int.Parse(coords[0]), int.Parse(coords[1])] == 0)
            {
                table[this.X_coord, this.Y_coord] = 0;
                table[int.Parse(coords[0]), int.Parse(coords[1])] = this.Id;
                this.X_coord = int.Parse(coords[0]);
                this.Y_coord = int.Parse(coords[0]);
            }
            else
            {
                //You can't move here
            }
        }
    }
}
