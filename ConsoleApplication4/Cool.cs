using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Cool
    {
        public int Number {get; set;}

        //override innebär skriver en ny och förbättrad version som vi ärvt från en basklass
        //override tar befälet över metoden
        //basklassens vitrual säger att det är ok att göra en override
        //kan göras på metoder, properties, events och indexer

        //här görs override från Object F12 och titta:
        Object obj;
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
