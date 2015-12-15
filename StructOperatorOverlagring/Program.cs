using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructOperatorOverlagring
{
    class Program
    {
        static void Main(string[] args)
        {
            Cyckel timCyckel = new Cyckel(3, 21);
            Cyckel zebbeCyckel = new Cyckel(1, 20);
            zebbeCyckel -= 12;
            int tal = 12 + zebbeCyckel;
            Console.WriteLine(zebbeCyckel);
            Console.ReadLine();
        }
    }
}
