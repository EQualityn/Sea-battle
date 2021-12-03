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
            ShipFactory Factory1 = new ShipFactory();

        }
        public int[,] CreateTable()
        {
            int[,] Table = new int[15, 15];
            return Table;
        }
    }
    
}
