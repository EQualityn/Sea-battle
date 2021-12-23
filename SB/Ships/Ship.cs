using SB.Interfaces;
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
        public string Type;
        public int Alivecells;
        public int X_coo;
        public int Y_coo;
        public bool Rotation = true;
        public string Picture;
        public int Cells;
        public bool featureRealised = false;
      public  Ship (int id, bool rotation, int x_coo, int y_coo, string type)   
        {
            this.Id = id;
            this.Rotation = rotation;
            this.X_coo = x_coo;
            this.Y_coo = y_coo;
            this.Type = type;
            this.Alivecells = ShipAliveCells(type);
            this.Picture = ShipPicture(type);
            this.Cells = ShipAliveCells(type);
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
                case "Bunker": return 4;
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

        
        //public abstract void Feature(Table table, int x, int y);

    }

    
}
