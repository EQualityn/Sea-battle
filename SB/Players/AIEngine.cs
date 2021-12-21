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

                    if (table.isDead) // если корабль убит, то заходим
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
                        table.shootAgain = true;
                        table.isDead = false;
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
                            int i = 1;
                            do
                            {
                                table.Shoot(x + i, y);
                                if (!table.shootAgain)
                                {
                                    right = false;
                                    left = true;
                                    break;
                                }
                                i++;
                            } while (x + i < 15);
                        }
                        if (y_hit < 15 && down)
                        {
                            int i = 1;
                            do
                            {
                                table.Shoot(x, y + i);
                                if (!table.shootAgain)
                                {
                                    down = false;
                                    right = true;
                                    break;
                                }
                                i++;
                            } while (y + i < 15);
                        }
                        if (y_hit > 0 && up)
                        {
                            int i = 1;
                            do
                            {
                                table.Shoot(x, y - i);
                                if (!table.shootAgain)
                                {
                                    up = false;
                                    down = true;
                                    break;
                                }
                                i++;
                            } while (y - i > 0);
                        }
                        if (x_hit > 0 && left)
                        {
                            int i = 1;
                            do
                            {
                                table.Shoot(x - i, y);
                                if (!table.shootAgain)
                                {
                                    left = false;
                                    up = true;
                                    break;
                                }
                                i++;
                            } while (x - i > 0);
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