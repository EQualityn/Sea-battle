using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB
{
    public class AIEngine : BasePlayer
    {
        int x_hit = 0;
        int y_hit = 0;
        bool right = false;
        bool down = false;
        bool up = false;
        bool left = true;
        public AIEngine()
        {
        }

        public override void Turn(string difficulty)
        {
            Random rnd = new Random();
            int x, y, key;

            switch (difficulty)
            {
                case "easy":

                    key = rnd.Next(0, 14);
                    table.ChooseFeature(key);
                    do
                    {
                      
                        x = rnd.Next(0, 14);
                        y = rnd.Next(0, 14);
                        table.Shoot(x, y);
                    } while (table.shootAgain);

                    Console.WriteLine($"Engine shot at {x}, {y}");
                    Console.WriteLine();
                    table.ShowTable();
                    Console.WriteLine();
                    break;
                case "medium":
                    // bool isHit = false;
                    // table isSunk = true;
                    // isSunk = false if ship.alivecells!=0;
                    // while isSunk (Shoot.Rand)
                    // while !isSunk =>ShootClever(Shoot while isHit);
                    key = rnd.Next(0, 14);
                    table.ChooseFeature(key);

                    if (table.t) // если корабль убит, то заходим
                    {
                        x = rnd.Next(0, 14);
                        y = rnd.Next(0, 14);
                        table.Shoot(x, y);
                        right = false;
                        down = false;
                        up = false;
                        left = true;
                    }
                    else
                    {
                        x = x_hit;
                        y = y_hit;
                        table.t = false;
                    }

                    Console.WriteLine($"Engine shot at {x}, {y}");
                    Console.WriteLine();
                    table.ShowTable();
                    Console.WriteLine();

                    while (table.shootAgain)
                    // switch rotation
                    {
                        x_hit = x;
                        y_hit = y;
                        if (x_hit < 15 && right)
                        {
                            for (int i = 0; ; i++)
                            {
                                table.Shoot(x + i, y);
                                if (!table.shootAgain && x + i < 15)
                                {
                                    right = false;
                                    left = true;
                                    table.t = true;
                                    break;
                                }
                            }
                        }
                        if (y_hit < 15 && down)
                        {
                            for (int i = 0; ; i++)
                            {
                                table.Shoot(x, y + i);
                                if (!table.shootAgain && y + i < 15)
                                {
                                    down = false;
                                    right = true;
                                    table.t = true;
                                    break;
                                }
                            }
                        }
                        if (y_hit > 0 && up)
                        {
                            for (int i = 0; ; i++)
                            {
                                table.Shoot(x, y - i);
                                if (!table.shootAgain && y - i > 0)
                                {
                                    up = false;
                                    down = true;
                                    table.t = true;
                                    break;
                                }
                            }
                        }
                        if (x_hit > 0 && left)
                        {
                            int i = 1;
                            do
                            {
                                table.Shoot(x - i, y);
                                if (!table.shootAgain && x - i > 0)
                                {
                                    left = false;
                                    up = true;
                                    table.t = true;
                                    break;
                                }
                                i++;
                            } while (true);
                        }

                        Console.WriteLine($"Engine shot at {x}, {y}");
                        Console.WriteLine();
                        table.ShowTable();
                        Console.WriteLine();
                    }
                    break;

                case "hard":

                    break;
            }

        }


    }
}