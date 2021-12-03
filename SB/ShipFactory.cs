using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SB.Ships;

namespace SB.ShipFactory
{
    abstract class ShipFactory
    {
        public string Name { get; set; }

        public ShipFactory()
        { }
        // фабричный метод
        abstract public Ship Create(string Name, int Id, bool Rotation, int X_coord, int Y_coord);
    }

    class Ship1Factory : ShipFactory
    {
        public Ship1Factory() : base()
        { }

        public override Ship Create(string Name, int Id, bool Rotation, int X_coord, int Y_coord)
        {
            return new Ship1(Name, Id, Rotation, X_coord, Y_coord);
        }
    }

    class Ship2Factory : ShipFactory
    {
        public Ship2Factory() : base()
        { }

        public override Ship Create(string Name, int Id, bool Rotation, int X_coord, int Y_coord)
        {
            return new Ship2(Name, Id, Rotation, X_coord, Y_coord);
        }
    }
    class Ship3Factory : ShipFactory
    {
        public Ship3Factory() : base()
        { }

        public override Ship Create(string Name, int Id, bool Rotation, int X_coord, int Y_coord)
        {
            return new Ship3(Name, Id, Rotation, X_coord, Y_coord);
        }
    }
    class Ship4Factory : ShipFactory
    {
        public Ship4Factory() : base()
        { }

        public override Ship Create(string Name, int Id, bool Rotation, int X_coord, int Y_coord)
        {
            return new Ship4(Name, Id, Rotation, X_coord, Y_coord);
        }
    }
    class Ship5Factory : ShipFactory
    {
        public Ship5Factory() : base()
        { }

        public override Ship Create(string Name, int Id, bool Rotation, int X_coord, int Y_coord)
        {
            return new Ship5(Name, Id, Rotation, X_coord, Y_coord);
        }
    }
    class Ship22Factory : ShipFactory
    {
        public Ship22Factory() : base()
        { }

        public override Ship Create(string Name, int Id, bool Rotation, int X_coord, int Y_coord)
        {
            return new Ship22(Name, Id, Rotation, X_coord, Y_coord);
        }
    }
}
