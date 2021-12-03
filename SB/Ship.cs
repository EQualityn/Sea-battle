using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB
{
  public abstract class Ship
    {
        public int Id;
        public string Name;
        public int Alivecells;
        public int X_coord;
        public int Y_coord;
        public bool Rotation;
        public string Picture;
      public  Ship (string Name,int Id, bool Rotation, int X_coord, int Y_coord)   
        {
            this.Name = Name;
            this.Id = Id;
            this.Rotation = Rotation;
            this.X_coord = X_coord;
            this.Y_coord = Y_coord;
            this.Alivecells = ShipAliveCells(Name);
            this.Picture = ShipPicture(Name);
        }
        public int ShipAliveCells(string Name)
        {
            switch (Name)
            {
                case "Carrier": return 5;
                case "Battleship": return 4;
                case "Cruiser": return 3;
                case "Destroyer": return 2;
                case "Corvette": return 1;
                case "Bunke": return 4;
                default: return 0;
            }
        }

        public string ShipPicture(string Name)
        {
            switch (Name)
            {
                case "Carrier": return "5ship.png";
                case "Battleship": return "4ship.png";
                case "Cruiser": return "3ship.png";
                case "Destroyer": return "2ship.png";
                case "Corvette": return "1ship.png";
                case "Bunker": return "22ship.png";
                default: return "";
            }
        }
    }

    
}
