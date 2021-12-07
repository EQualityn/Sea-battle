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

        }
        
    }
}
