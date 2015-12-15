using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structisar
{
    struct Mixture
    {
        public bool MyBool;
        public double MyDouble;
        public Int64 MyInt;

        //public Mixture()
        //{
        //    MyBool = true;
        //    MyDouble = 3.21;
        //    MyInt = 1337;
        //}
        //public Mixture(bool myBool, double myDouble, Int64 myInt)
        //{
        //    MyBool = myBool;
        //    MyDouble = myDouble;
        //    MyInt = myInt;
        //}
        public override string ToString() => $"MyBool: {MyBool}, MyDouble: {MyDouble}, MyInt: {MyInt}";
    }
}
