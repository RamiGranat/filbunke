using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Dog : Animal
    {
        private string djur = "hund";
        private string Djur { get; set; }
        public override void PrintInfo()
        {
            Console.WriteLine($"Djur: {Djur}, Name: {Name}");
        }
    }
}
