using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SB
{
    public class Table
    {
        // Скрытые поля
        public int n;
        public int[,] table;
        public int[,] Quasitable =
      { { 0,1,0,2,0,0,0,4,0,0,0,0,0,0,0 },
        { 0,0,0,0,0,3,0,0,0,0,0,0,0,0,0 },
        { 7,0,0,0,0,0,0,0,0,0,0,0,8,0,0 },
        { 7,0,0,0,0,0,0,5,0,0,0,0,8,0,0 },
        { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
        { 6,0,0,0,0,0,0,0,0,0,0,9,0,0,0 },
        { 6,0,0,0,0,0,0,0,0,0,0,9,0,0,0 },
        { 0,0,0,0,0,0,12,0,0,0,0,9,0,0,0 },
        { 0,0,14,14,0,0,12,0,0,0,0,0,0,0,0 },
        { 0,0,14,14,0,0,12,0,0,0,10,10,10,0,0 },
        { 0,0,0,0,0,0,12,0,0,0,0,0,0,0,0 },
        { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
        { 0,0,0,0,0,0,0,0,11,11,11,11,0,0,0 },
        { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
        { 0,13,13,13,13,13,0,0,0,0,0,0,0,0,0 } };
        // Создаем конструкторы матрицы


        // Задаем аксессоры для работы с полями вне класса Matrix
        public Table(int n)
        {
            this.n = n;
            table = new int[this.n, this.n];
        }
        public int this[int i, int j]
        {
            get
            {
                return table[i, j];
            }
            set
            {
                table[i, j] = value;
            }
        }
        public void ShowTable()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write((table[i, j]).ToString().PadLeft(4));
                }
                Console.WriteLine("");
            }
        }
        public static Table QuasiTable()
        {
            Table Quasi = new Table(15);
            Quasi.table = Quasi.Quasitable;
            return Quasi;
        }
        public bool CheckAlive()
        {
           
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (table[i, j] > 0)
                        return true;
                }
                
            }
            return true;
        }
    }
}
