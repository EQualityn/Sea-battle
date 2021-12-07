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

        static void Main(string[] args)
        {
            Table table = new Table(15);
            table.AutoDisposal();
            table.Shoot(10, 10);
         
            Console.ReadLine();
        }

    }

}
