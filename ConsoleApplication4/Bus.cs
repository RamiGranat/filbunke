using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Bus
    {

        public int HorsePowers
        { get; set; }

        public int Seats
        {  get;  set; }
        public Bus(int seats, int horsePowers)
        {
            HorsePowers = horsePowers;
            Seats = seats;
        }
        public override string ToString()
        {
            return string.Format("Seats: {0}, HorsePowers{1}", Seats, HorsePowers);
        }
    }
}
