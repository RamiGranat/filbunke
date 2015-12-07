using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat() { Name = "Kajsa", Age = 5 };
            cat.PrintInfo();
            Console.WriteLine(cat);
            Animal dog = new Dog() { Name = "Doge", Age = 100 };
            dog.PrintInfo();
            Console.WriteLine(dog);
            Console.ReadLine();
        }
    }
}
