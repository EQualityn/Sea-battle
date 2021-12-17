using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB
{
    public class Player : BasePlayer
    {
 
      
        public Player()
        {
        }

       
        public override void ShootStrategy(string difficultyMode)
        {
          
            do
            {
                int key = int.Parse(Console.ReadLine());
                table.ChooseFeature(key);
                Console.WriteLine("Enter x and y to shoot at");
                var coords = Console.ReadLine().Split();
                table.Shoot(int.Parse(coords[0]), int.Parse(coords[1])); // or y,x?
                Console.WriteLine($"Player shot at {coords[0]}, {coords[1]}");
                Console.WriteLine();
                table.ShowTable();
                Console.WriteLine();
            } while (table.lastSuccessShot);


        }
        //List<Ship> Ships = new List<Ship>();
        //public void ArmWithShips(List<Ship> Ships)
        //{
        //    ShipFactory Factory1 = new Ship1Factory();
        //    ShipFactory Factory2 = new Ship2Factory();
        //    ShipFactory Factory3 = new Ship3Factory();
        //    ShipFactory Factory4 = new Ship4Factory();
        //    ShipFactory Factory5 = new Ship5Factory();
        //    ShipFactory Factory22 = new Ship22Factory();

        //}

    }
}
