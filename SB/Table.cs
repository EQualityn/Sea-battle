﻿
using Newtonsoft.Json;
using SB.Ships;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace SB
{
    public class Table
    {
        // Скрытые поля
        public int n;
        public int[,] table;
        public List<Ship> ships = new List<Ship>();
        public bool shootAgain = false;
        public bool isDead = true;
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
        public void DecodeField(string decodedShips)
        {
            // String decodedShips = "{\"Type\":\"Corvette\",\"Rotation\":false,\"X_coo\":6,\"Y_coo\":1}";
            Ship1 ship = JsonConvert.DeserializeObject<Ship1>(decodedShips);
            decodedShips = decodedShips.Remove(0, 21);
            decodedShips = decodedShips.Remove(decodedShips.Length-2);

            string[] help = decodedShips.Split(new char[] {'}'} );
            for (int i = 0; i < help.Length-1; i++)
            {
                help[i] = help[i].Remove(0,2);
                if (help[i].IndexOf("Corvette") == 8)
                {
                    if(help[0][help[i].IndexOf('R') + 10] == 'f')
                    {
                        ship.Rotation = false;
                    }
                    else
                    {
                        ship.Rotation = true;
                    }

                }
                Console.WriteLine(help[i]);
            }
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
            return false;
        }
        public int HealthOfFleet()
        {
            int health = 0;
            //foreach (Ship ship in ships)
            //{
            //    health += ship.Alivecells;
            //}

            return health = ships.Select(ship => ship.Alivecells).Sum();
        }
        public void AutoDisposal()
        {
            ShipFactory Factory1 = new Ship1Factory();
            ShipFactory Factory2 = new Ship2Factory();
            ShipFactory Factory3 = new Ship3Factory();
            ShipFactory Factory4 = new Ship4Factory();
            ShipFactory Factory5 = new Ship5Factory();
            ShipFactory Factory22 = new Ship22Factory();

            int Alivecells;
            int x = 0, y = 0;
            bool rotate = false;

            Alivecells = 5;
            Ship Ship5 = Factory5.Create(13, rotate, x, y);
            AutoCheck(Ship5, Alivecells, ref rotate, table, 13);
            ships.Add(Ship5);

            Alivecells = 4;
            Ship Ship22 = Factory22.Create(14, rotate, x, y);
            AutoCheck(Ship22, Alivecells, ref rotate, table, 14);
            ships.Add(Ship22);
            for (int i = 11; i < 13; i++)
            {
                Alivecells = 4;
                Ship Ship4 = Factory4.Create(i, rotate, x, y);
                AutoCheck(Ship4, Alivecells, ref rotate, table, i);
                ships.Add(Ship4);
            }

            for (int i = 9; i < 11; i++)
            {
                Alivecells = 3;
                Ship Ship3 = Factory3.Create(i, rotate, x, y);
                AutoCheck(Ship3, Alivecells, ref rotate, table, i);
                ships.Add(Ship3);
            }
            for (int i = 6; i < 9; i++)
            {
                Alivecells = 2;
                Ship Ship2 = Factory2.Create(i, rotate, x, y);
                AutoCheck(Ship2, Alivecells, ref rotate, table, i);
                ships.Add(Ship2);
            }
            for (int i = 1; i < 6; i++)
            {
                Alivecells = 1;
                Ship Ship1 = Factory1.Create(i, rotate, x, y);
                AutoCheck(Ship1, Alivecells, ref rotate, table, i);
                ships.Add(Ship1);
            }
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (table[i, j] == -2)
                    {
                        table[i, j] = 0;
                    }
                }
            }

            string json = JsonConvert.SerializeObject(ships);
            File.WriteAllText(@"autodisposal.json", json);

        }
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
        //Marking hit fields around if ship set

        void Zone(int Id, int Alivecells, ref bool rotate, int[,] field, int x, int y)
        {
            if (Id == 14)
            {
                for (int dx = -1; dx <= Alivecells / 2; dx++)
                    for (int dy = -1; dy <= Alivecells / 2; dy++)
                        if ((x + dx >= 0) && (x + dx < 15) && (y + dy >= 0) && (y + dy < 15))
                            if (field[x + dx, y + dy] != Id && field[x + dx, y + dy] != -1)
                                field[x + dx, y + dy] = -2;
            }
            else
            {
                if (rotate)
                {
                    for (int dx = -1; dx <= 1; dx++)
                        for (int dy = -1; dy <= Alivecells; dy++)
                            if ((x + dx >= 0) && (x + dx < 15) && (y + dy >= 0) && (y + dy < 15))
                                if (field[x + dx, y + dy] != Id && field[x + dx, y + dy] != -1)
                                    field[x + dx, y + dy] = -2;
                }
                else
                {
                    for (int dx = -1; dx <= Alivecells; dx++)
                        for (int dy = -1; dy <= 1; dy++)
                            if ((x + dx >= 0) && (x + dx < 15) && (y + dy >= 0) && (y + dy < 15))
                                if (field[x + dx, y + dy] != Id && field[x + dx, y + dy] != -1)
                                    field[x + dx, y + dy] = -2;
                }
            }
        }

        void AutoCheck(Ship ship, int Alivecells, ref bool rotate, int[,] field, int Id)
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
                ship.X_coo = x;
                ship.Y_coo = y;
                ship.Rotation = rotate;
                if (Id == 14)
                {
                    if ((x >= 0) && (x < 15) && (y >= 0) && (y < 15) && field[x, y] != -2)
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
                                if (field[x + i, y + j] == -2)
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
                else if ((x >= 0) && (x < 15) && (y >= 0) && (y < 15) && field[x, y] != -2)
                {

                    if (rotate && (y + Alivecells - 1 >= 0) && (y + Alivecells - 1 < 15) && field[x, y + Alivecells - 1] != -2)
                    {
                        for (int i = 0; i <= Alivecells - 1; i++)
                        {
                            if (field[x, y + i] == -2)
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
                    if (!rotate && (x + Alivecells - 1 >= 0) && (x + Alivecells - 1 < 15) && field[x + Alivecells - 1, y] != -2)
                    {
                        for (int i = 0; i <= Alivecells - 1; i++)
                        {
                            if (field[x + i, y] == -2)
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
        // public bool isHit = false;
        //  public bool isSunk = true;
        public void HitCheck(int x, int y)
        {
            Ship hitShip = ships.SingleOrDefault(ship => ship.Id == table[y, x]);
            if (table[y, x] > 0)
            {

            }
        }

        public void ChooseFeature(int key)
        {

            var frame = new StackFrame(1);
            if (frame.GetMethod().DeclaringType.Name == "Player")
            {

                var featurableShip = ships.FirstOrDefault(ship => ship.Id == key);
                //ships.FirstOrDefault(ship => ship.Id == key).Feature();


                if (featurableShip is Ship22)
                {
                    Console.WriteLine("Double shot x and y:");
                    string[] coords = Console.ReadLine().Split();
                    ((Ship22)featurableShip).Feature(this, int.Parse(coords[0]), int.Parse(coords[1]));

                }
                if (featurableShip is Ship5)
                {
                    Console.WriteLine("Line to shoot at:");
                    int line = int.Parse(Console.ReadLine());
                    ((Ship5)featurableShip).Feature(this, line, 1);
                }

            }
            else
            {
                var featurableShip = ships.FirstOrDefault(ship => ship.Id == key);
                //ships.FirstOrDefault(ship => ship.Id == key).Feature();
                Random rnd = new Random();

                if (featurableShip is Ship22)
                {

                    int x = rnd.Next(0, 14);
                    int y = rnd.Next(0, 14);
                    ((Ship22)featurableShip).Feature(this, x, y);

                }
                if (featurableShip is Ship5)
                {
                    int line = rnd.Next(0, 14);
                    ((Ship5)featurableShip).Feature(this, line, 1);

                }
            }


        }



        public void Shoot(int x, int y)
        {
            //try catch if beyond bounds
            if (table[y, x] > 0)
            {
                foreach (Ship ship in ships)
                {
                    if (ship.Id == table[y, x])
                    {
                        table[y, x] = -1;
                        ship.Alivecells--;
                        //ship.isHit = true;
                        shootAgain = true;
                        isDead = false;

                        if (ship.Alivecells == 0)
                        {
                            isDead = true;
                            Zone(ship.Id, ship.Cells, ref ship.Rotation, table, ship.X_coo, ship.Y_coo);
                            break;
                        }
                    }

                }
            }
            if (table[y, x] < 0)
            {
                shootAgain = true;
                //y = 14;
            }

            if (table[y, x] == 0)
            {
                table[y, x] = -2;
                shootAgain = false;
            }
            var frame = new StackFrame(1);
            if (frame.GetMethod().DeclaringType.Name == "Player")
            {
                int[,] playerShots = fillTableForFront();
                GlobalVariablesForGame.enemyFieldShot = playerShots;
            }
            else
            {
                int[,] engineShots = fillTableForFront();
                GlobalVariablesForGame.myFieldShot = engineShots;
                Console.WriteLine(engineShots[0,0]);
            }

        }
        public int[,] fillTableForFront()
        {
            int[,] toFront = new int[225, 2];
            int k=0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (table[i, j] < 0)
                    {
                        toFront[k, 0] = j+1;
                        toFront[k, 1] = i+1;
                        k++;
                    }
                }
            }
            return toFront;
        }

    }
}
