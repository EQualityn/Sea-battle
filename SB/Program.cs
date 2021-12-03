using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SB
{
    class Program
    {

        static void Main(string[] args)
        {
           
          //  Ship Ship1 = Factory1.Create(1, false, 2, 3);
            //Table table = new Table(15);
            Table table1 = Table.QuasiTable();
            //Table table1 = table.QuasiTable();
            
            table1.ShowTable();
            Console.WriteLine(table1.CheckAlive());
            Console.ReadLine();
            //  Ship1.Shoot();
        }
        //public int[,] CreateTable()
        //{
        //    int[,] Table = new int[15, 15];
        //    return Table;
        //}
        public static void Battle(Table table)
        {
            while (table.CheckAlive())
            {
                
            }
        }
    }
    
}
