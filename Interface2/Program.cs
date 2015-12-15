using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    class Program : IChildInterface
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.ChildMethod();
            //program.ParentMethod();
            ArvFromEttTvauInterfacen arv = new ArvFromEttTvauInterfacen();
            IEtt ittan = (IEtt)arv;

            Console.ReadLine();
        }

        public void ChildMethod()
        {
            Console.WriteLine("Child");
        }

        public void ParentMethod()
        {
            Console.WriteLine("Parent");
        }
    }
}
