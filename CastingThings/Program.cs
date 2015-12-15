using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingThings
{
    class Program
    {
        static void Main(string[] args)
        {
            long tal = 5;
            Farenheit farenheit = new Farenheit(100.0f);
            Console.WriteLine($"Farenheit: {farenheit.Temp}");

            //Casta farenheit -> celsius
            Celsius celsius = (Celsius)farenheit;
            Console.WriteLine($"Celsius: {celsius.Temp}");

            //Casta celsius -> farenheit
            Farenheit farenheit2 = (Farenheit)celsius;
            Console.WriteLine($"Farenheit: {farenheit2.Temp}");

            Point point = new Point(11, 22);
            Console.WriteLine($"X: {point.X}, Y: {point.Y}");

            Point3D point3D = (Point3D)point;
            Console.WriteLine($"X: {point3D.X}, Y: {point3D.Y}, Z: {point3D.Z}");

            Point point2 = (Point)point3D;
            Console.WriteLine($"X: {point2.X}, Y: {point2.Y}");
        }
    }
}
