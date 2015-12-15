using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felhantering
{
    class Class1
    {
        public void Method()
        {
            try
            {

            var tal = 67 / int.Parse(Console.ReadLine()); //Division med 0 ger en crash divideByZeroException
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Message" + $"{ex.Message}\r\nSource:{ex.Source}\r\nStackTrace: {ex.StackTrace}");
                Console.WriteLine(ex.Message);
                Method();
            }
        Console.WriteLine("Metoden i klassen");
        }
    }
}
