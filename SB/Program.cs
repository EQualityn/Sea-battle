using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SB;

namespace SB
{
    class Program
    {
        static void Main(string[] args)
        {
            ShipFactory Factory1 = new Ship1Factory();
            ShipFactory Factory2 = new Ship2Factory();
            ShipFactory Factory3 = new Ship3Factory();
            ShipFactory Factory4 = new Ship4Factory();
            ShipFactory Factory5 = new Ship5Factory();
            ShipFactory Factory22 = new Ship22Factory();

        }
        public int[,] CreateTable()
        {
            int[,] Table = new int[15, 15];
            return Table;
        }
    }
    
}
