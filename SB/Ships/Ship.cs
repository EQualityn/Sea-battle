using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB
{
    public interface IFeaturable
    {
        void Feature(Table table, int x, int y);
    }
    public abstract class Ship
    {
        public int Id;
        public string Name;
        public int Alivecells;
        public int X_coord;
        public int Y_coord;
        public bool Rotation = true;
        public string Picture;
        public bool isHit = false;
        public bool isSunk;
        public int Cells;
        //private IBattleField _battleField;
      public  Ship (int id, bool rotation, int x_coord, int y_coord, string name)   
        {
            this.Id = id;
            this.Rotation = rotation;
            this.X_coord = x_coord;
            this.Y_coord = y_coord;
            this.Name = name;
            this.Alivecells = ShipAliveCells(name);
            this.Picture = ShipPicture(name);
            this.Cells = ShipAliveCells(name);
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
