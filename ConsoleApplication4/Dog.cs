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
        public override void PrintInfo()
        {
            Console.WriteLine($"Djur: {djur}, Name: {Name}");
        }
        public override string ToString() => $"Djur: {djur} " + base.ToString();
    }
}
