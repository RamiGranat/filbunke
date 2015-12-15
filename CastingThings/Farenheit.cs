using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingThings
{
    class Farenheit
    {
        public float Temp { get; set; }
        public Farenheit(float temp) { Temp = temp; }
        //Explicit innebär förlust av data (oftast en property som inte finns i retur-klassen)
        //Implicit brukar innebära att returklassen har en delmängd från ursprungliga
        public static implicit operator Celsius(Farenheit farenheit)
        {
            return new Celsius((9.0f/5.0f)*farenheit.Temp - 32);
        }
    }
}
