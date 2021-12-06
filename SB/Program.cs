using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SB;

namespace SB
{
    class Program
    {

        static void AutoDisposal()
        {
            ShipFactory Factory1 = new Ship1Factory();
            ShipFactory Factory2 = new Ship2Factory();
            ShipFactory Factory3 = new Ship3Factory();
            ShipFactory Factory4 = new Ship4Factory();
            ShipFactory Factory5 = new Ship5Factory();
            ShipFactory Factory22 = new Ship22Factory();

            bool ButtonAuto = true;
            if (ButtonAuto == true)
            {
                int Alivecells;
                int x = 0, y = 0;

                bool rotate = false;
                Table table = new Table(15);
                Alivecells = 5;
                Ship Ship5 = Factory5.Create(13, rotate, x, y);
                AutoCheck(Ship5, Alivecells, ref rotate, table, 13);

                Alivecells = 4;
                Ship Ship22 = Factory22.Create(14, rotate, x, y);
                AutoCheck(Ship22, Alivecells, ref rotate, table, 14);

                for (int i = 11; i < 13; i++)
                {
                    Alivecells = 4;
                    Ship Ship4 = Factory4.Create(i, rotate, x, y);
                    AutoCheck(Ship4, Alivecells, ref rotate, table, i);

                }

                for (int i = 9; i < 11; i++)
                {
                    Alivecells = 3;
                    Ship Ship3 = Factory3.Create(i, rotate, x, y);
                    AutoCheck(Ship3, Alivecells, ref rotate, table, i);

                }
                for (int i = 6; i < 9; i++)
                {
                    Alivecells = 2;
                    Ship Ship2 = Factory2.Create(i, rotate, x, y);
                    AutoCheck(Ship2, Alivecells, ref rotate, table, i);

                }
                for (int i = 1; i < 6; i++)
                {
                    Alivecells = 1;
                    Ship Ship1 = Factory1.Create(i, rotate, x, y);
                    AutoCheck(Ship1, Alivecells, ref rotate, table, i);

                }
                for (int i = 0; i < 15; i++)
                {
                    for (int j = 0; j < 15; j++)
                    {
                        if (table[i, j] == -1)
                        {
                            table[i, j] = 0;
                        }
                    }

                }
                //table.ShowTable();


                string json = JsonConvert.SerializeObject(table);
                File.WriteAllText(@"autodisposal.json", json);

            }
            //void Battle(Table table)
            //{
            //    while (table.CheckAlive())
            //    {

            //    }
            //}

            void Rand(ref int x, ref int y, ref bool rotate)
            {
                Random rnd = new Random();
                x = rnd.Next(0, 14);
                y = rnd.Next(0, 14);
                for (int i = 1; i <= 1; i++)
                {
                    rotate = rnd.Next(2) == 0 ? false : true;
                }
            }

            void Zone(int Id, int Alivecells, ref bool rotate, Table field, int x, int y)
            {
                if (Id == 14)
                {
                    for (int dx = -1; dx <= Alivecells / 2; dx++)
                        for (int dy = -1; dy <= Alivecells / 2; dy++)
                            if ((x + dx >= 0) && (x + dx < 15) && (y + dy >= 0) && (y + dy < 15))
                                if (field[x + dx, y + dy] != Id)
                                    field[x + dx, y + dy] = -1;
                }
                else
                {
                    if (rotate)
                    {
                        for (int dx = -1; dx <= 1; dx++)
                            for (int dy = -1; dy <= Alivecells; dy++)
                                if ((x + dx >= 0) && (x + dx < 15) && (y + dy >= 0) && (y + dy < 15))
                                    if (field[x + dx, y + dy] != Id)
                                        field[x + dx, y + dy] = -1;
                    }
                    else
                    {
                        for (int dx = -1; dx <= Alivecells; dx++)
                            for (int dy = -1; dy <= 1; dy++)
                                if ((x + dx >= 0) && (x + dx < 15) && (y + dy >= 0) && (y + dy < 15))
                                    if (field[x + dx, y + dy] != Id)
                                        field[x + dx, y + dy] = -1;
                    }
                }
            }

            void AutoCheck(Ship ship, int Alivecells, ref bool rotate, Table field, int Id)
            {
                bool flag = true;
                int x = 0, y = 0;
                do
                {
                    ship.Alivecells = Alivecells;
                    ship.Id = Id;
                pook:
                    flag = true;
                    Rand(ref x, ref y, ref rotate);
                    ship.X_coord = x;
                    ship.Y_coord = y;
                    ship.Rotation = rotate;
                    if (Id == 14)
                    {
                        if ((x >= 0) && (x < 15) && (y >= 0) && (y < 15) && field[x, y] != -1)
                        {
                            for (int i = 0; i < 2; i++)
                            {
                                for (int j = 0; j < 2; j++)
                                {
                                    for (int k = 1; k < 14; k++)
                                    {
                                        if (field[x + i, y + j] == k)
                                        {
                                            goto pook;
                                        }
                                    }
                                    if (field[x + i, y + j] == -1)
                                    {
                                        goto pook;
                                    }
                                }
                            }
                            flag = false;
                        }
                        if (!flag)
                        {
                            break;
                        }
                        goto pook;
                    }
                    else if ((x >= 0) && (x < 15) && (y >= 0) && (y < 15) && field[x, y] != -1)
                    {

                        if (rotate && (y + Alivecells - 1 >= 0) && (y + Alivecells - 1 < 15) && field[x, y + Alivecells - 1] != -1)
                        {
                            for (int i = 0; i <= Alivecells - 1; i++)
                            {
                                if (field[x, y + i] == -1)
                                {
                                    goto pook;
                                }
                                for (int j = 1; j <= 14; j++)
                                {
                                    if (field[x, y + i] == j || field[x, y + Alivecells - 1] == j)
                                    {
                                        goto pook;
                                    }
                                }
                            }

                            flag = false;
                        }
                        if (!rotate && (x + Alivecells - 1 >= 0) && (x + Alivecells - 1 < 15) && field[x + Alivecells - 1, y] != -1)
                        {
                            for (int i = 0; i <= Alivecells - 1; i++)
                            {
                                if (field[x + i, y] == -1)
                                {
                                    goto pook;
                                }
                                for (int j = 1; j <= 14; j++)
                                {
                                    if (field[x + i, y] == j || field[x + Alivecells - 1, y] == j)
                                    {
                                        goto pook;
                                    }
                                }
                            }

                            flag = false;
                        }
                        if (!flag)
                            break;
                        goto pook;
                    }
                } while (true);
                if (Id == 14)
                {
                    for (int i = y; i <= y + (Alivecells / 2) - 1; i++)
                        for (int j = x; j <= x + (Alivecells / 2) - 1; j++)
                            field[j, i] = Id;
                }
                else
                {
                    if (rotate)
                    {
                        for (int i = y; i <= y + Alivecells - 1; i++)
                        {
                            field[x, i] = Id;
                        }
                    }
                    else
                    {
                        for (int i = x; i <= x + Alivecells - 1; i++)
                        {
                            field[i, y] = Id;
                        }
                    }
                }
                Zone(Id, Alivecells, ref rotate, field, x, y);

            }

        }



        static void Main(string[] args)
        {
            AutoDisposal();
            Console.ReadLine();
        }

    }

}
