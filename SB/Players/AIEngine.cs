using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB
{
   public class AIEngine : BasePlayer, IGetTableable, IShootable
    { 
        public Table EngineTable = new Table(15);
        
        public Table GetTable()
        {
            return EngineTable;
        }
        public void ShootStrategy()
        {
            
        }
        public AIEngine()
        {
        }

    }
}
