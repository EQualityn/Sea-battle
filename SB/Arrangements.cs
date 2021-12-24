using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Arrangments
    {
        static public string Battle =
            "{\"BattleArrangement\":" +
            "[{\"Type\":\"Corvette\",\"Rotation\":false,\"X_coo\":6,\"Y_coo\":1}," +
            "{\"Type\":\"Corvette\",\"Rotation\":false,\"X_coo\":5,\"Y_coo\":4}," +
            "{\"Type\":\"Corvette\",\"Rotation\":false,\"X_coo\":7,\"Y_coo\":3}," +
            "{\"Type\":\"Corvette\",\"Rotation\":false,\"X_coo\":4,\"Y_coo\":2}," +
            "{\"Type\":\"Corvette\",\"Rotation\":false,\"X_coo\":2,\"Y_coo\":4}," +
            "{\"Type\":\"Destroyer\",\"Rotation\":false,\"X_coo\":13,\"Y_coo\":3}," +
            "{\"Type\":\"Destroyer\",\"Rotation\":false,\"X_coo\":9,\"Y_coo\":2}," +
            "{\"Type\":\"Destroyer\",\"Rotation\":false,\"X_coo\":13,\"Y_coo\":1}," +
            "{\"Type\":\"Cruiser\",\"Rotation\":false,\"X_coo\":1,\"Y_coo\":7}," +
            "{\"Type\":\"Cruiser\",\"Rotation\":false,\"X_coo\":8,\"Y_coo\":5}," +
            "{\"Type\":\"Battleship\",\"Rotation\":false,\"X_coo\":5,\"Y_coo\":7}," +
            "{\"Type\":\"Battleship\",\"Rotation\":false,\"X_coo\":12,\"Y_coo\":5}," +
            "{\"Type\":\"Carrier\",\"Rotation\":false,\"X_coo\":10,\"Y_coo\":7}," +
            "{\"Type\":\"Bunker\",\"Rotation\":true,\"X_coo\":13,\"Y_coo\":13}]}";

            //@"{ ""BattleArrangement"" :
            //    [
            //    ""Name"" :""Corvette"",""Rotation"":false,""X_coo"":6,""Y_coo"":1,
            //    ""Name"":""Corvette"",""Rotation"":false,""X_coo"":5,""Y_coo"":4,
            //    ""Name"":""Corvette"",""Rotation"":false,""X_coo"":7,""Y_coo"":3,
            //    ""Name"":""Corvette"",""Rotation"":false,""X_coo"":4,""Y_coo"":2,
            //    ""Name"":""Corvette"",""Rotation"":false,""X_coo"":2,""Y_coo"":4,
            //    ""Name"":""Destroyer"",""Rotation"":false,""X_coo"":13,""Y_coo"":3,
            //    ""Name"":""Destroyer"",""Rotation"":false,""X_coo"":9,""Y_coo"":2,
            //    ""Name"":""Destroyer"",""Rotation"":false,""X_coo"":13,""Y_coo"":1,
            //    ""Name"":""Cruiser"",""Rotation"":false,""X_coo"":1,""Y_coo"":7,
            //    ""Name"":""Cruiser"",""Rotation"":false,""X_coo"":8,""Y_coo"":5,
            //    ""Name"":""Battleship"",""Rotation"":false,""X_coo"":5,""Y_coo"":7,
            //    ""Name"":""Battleship"",""Rotation"":false,""X_coo"":12,""Y_coo"":5,
            //    ""Name"":""Carrier"","" Rotation"":false,""X_coo"":10,""Y_coo"":7,
            //    ""Name"":""Bunker"",""Rotation"":true,""X_coo"":13,""Y_coo"":13
            //]}";
            //https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to?pivots=dotnet-core-3-1 внизу пример наш, но по-хорошему так
            // как расстановка привязана к конкретному игроку, то и класс должен быть не статическим, а принадлежащим классу либо Player либо Person.
        public string SaveArrangments { get; set; }
    }
}