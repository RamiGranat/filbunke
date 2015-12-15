using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structisar
{
    class Program
    {
        static void Main(string[] args)
        {
            //StructDemo1();
            //PointStruct();
            Mixture mixture = new Mixture() { MyBool = true, MyDouble = 1.21, MyInt = 42 };
            Console.WriteLine(mixture);
            Console.ReadLine();
        }

        private static void PointStruct()
        {
            Point ett;
            ett.X = 4;
            ett.Y = 5;
            ett = new Point(0);
            Console.WriteLine("X: {0}, Y: {1}", ett.X, ett.Y);
            Console.WriteLine(ett.GetXY());
        }

        private static void StructDemo1()
        {
            Koordinat koordinat;
            koordinat.X = 66;
            koordinat.Y = 88;

            Koordinat origo = new Koordinat() { X = 50, Y = 50 };
            origo.Z = "19";
            origo = new Koordinat(); /*Nollställer structen
            alla fält får defaultvärdet för respektive datatyp
            observera att string fick null i sig nu*/
            Console.WriteLine(origo);
        }
    }
}
