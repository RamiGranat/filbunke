using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Felhantering
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

            Class2.Method();
            }
            catch (Exception)
            {
                Console.WriteLine("Hanterat här i MAIN!!!");//Debug.WriteLine();
                //throw new Exception();
            }
            finally
            {
                //Oavsett vad som skett om det gick bra eller om vi hamnade i en catch
                //Så kommer det som står här att göras efter
                Console.WriteLine("Efter allt");
            }
            //Class1 class1 = new Class1();
            //class1.Method();
            Console.ReadLine();
        }
    }
}
