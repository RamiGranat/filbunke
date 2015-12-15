using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceus
{
    internal interface IInterface
    {
        void Method();
    }
    interface IInterface2 : IInterface
    {
        void MethodTwo();
    }
    class MyClass : IInterface
    {
        //Enligt kontraktet med interfacet måste vi skapa en metodkropp som hanterar den metod som är deklarerad i interfacet
        public void Method()
        {
            Console.WriteLine("Implementerat interfacet:-)");
        }
    }
}
