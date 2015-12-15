using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableNgnting
{
    class ThreeAttributes : IComparable<ThreeAttributes>
    {
        public int Ett { get; set; }
        public int Tvau { get; set; }
        public int Tre { get; set; }
        public ThreeAttributes(int ett, int tvau, int tre)
        {
            Ett = ett;
            Tvau = tvau;
            Tre = tre;
        }
        public override string ToString()
        {
            return string.Format ($"{Ett}, {Tvau}, {Tre}");
        }

        public int CompareTo(ThreeAttributes other)
        {
            return this.Ett.CompareTo(other.Ett);
        }
    }

}
