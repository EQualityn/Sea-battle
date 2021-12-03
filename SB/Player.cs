using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB
{
    public class Player
    {
        Table table;
      
        List<Ship> Ships = new List<Ship>();
        public void ArmWithShips(List<Ship> Ships)
        {
            ShipFactory Factory1 = new Ship1Factory();
            ShipFactory Factory2 = new Ship2Factory();
            ShipFactory Factory3 = new Ship3Factory();
            ShipFactory Factory4 = new Ship4Factory();
            ShipFactory Factory5 = new Ship5Factory();
            ShipFactory Factory22 = new Ship22Factory();
            Ships.Add(Factory1.Create(1, false, 1, 0));
            Ships.Add(Factory1.Create(2, false, 3, 0));
            Ships.Add(Factory1.Create(3, false, 5, 1));
            Ships.Add(Factory1.Create(4, false, 7, 0));
            Ships.Add(Factory1.Create(5, false, 3, 4));
            Ships.Add(Factory2.Create(6, false, 0, 5));
            Ships.Add(Factory2.Create(7, false, 0, 2));
            Ships.Add(Factory2.Create(8, false, 12, 2));
            Ships.Add(Factory3.Create(9, false, 11, 5));
            Ships.Add(Factory3.Create(10, false, 10, 9));
            Ships.Add(Factory4.Create(11, false, 8, 12));
            Ships.Add(Factory4.Create(12, false, 6, 8));
            Ships.Add(Factory5.Create(13, false, 1, 14));
            Ships.Add(Factory22.Create(14, false, 2, 8));
        }
        
    }
}
