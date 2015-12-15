using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structisar
{
    struct Point
    {
        public int X;
        public int Y;
        /*
        - man får ite göra en tom konstructor
        - om man gör en överlagrad konstructor måste man sätta
        ett värde på alla fält!*/
        public Point(int x)
        {
            X = x;
            Y = 7;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int GetXY()
        {
            return X + Y;
        }

    }
}
