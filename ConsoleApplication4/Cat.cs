using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Cat : Animal
    {
        private string djur = "katt";
        
        public override void PrintInfo()
        {
            Console.WriteLine($"Djur: {djur}, Name: {Name}");
        }
    }
}
