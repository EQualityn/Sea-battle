using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB
{
    class GlobalVariablesForGame
    {
        public static bool Turn { get; set; }
        public static int[,] myFieldShot { get; set; }
        public static int[,] enemyFieldShot { get; set; }
    }
}
