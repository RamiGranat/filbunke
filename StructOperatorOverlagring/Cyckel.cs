using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructOperatorOverlagring
{
    struct Cyckel
    {
        private int val, min, max;
        //Växlar vald, lägst högst...
        public Cyckel(int min, int max)
        {
            val = min;
            this.min = min;
            this.max = max;
        }
        public int Val
        {
            get { return val; }
            set {
                if (value >= min && value <= max)
                    val = value;
                else val = min;
            }
        }
        public static Cyckel operator +(Cyckel cyckel, int tal)
        {
            //Om klass gör vi så här:
            /*Om vi skapat referenstyp/class måste vi skapa en
            kopia som vi returnerar så att inte det objekt som
            skickas in pekas på från 2 eller fler ställen...*/
            // return new CYckel(1, cyckel.max += tal);
            cyckel.max += tal;
            return cyckel;
        }
        public static Cyckel operator -(Cyckel cyckel, int tal)
        {
            cyckel.max -= tal;
            return cyckel;
        }
        public static Cyckel operator *(Cyckel cyckel, int tal)
        {
            cyckel.max *= tal;
            return cyckel;
        }
        public static Cyckel operator /(Cyckel cyckel, int tal)
        {
            cyckel.max /= tal;
            return cyckel;
        }
        public static int operator +(int tal, Cyckel cyckel)
        {
            tal += cyckel.max;
            return tal;
        }
        public static int operator -(int tal, Cyckel cyckel)
        {
            tal -= cyckel.max;
            return tal;
        }
        public static int operator *(int tal, Cyckel cyckel)
        {
            tal *= cyckel.max;
            return tal;
        }
        public static int operator /(int tal, Cyckel cyckel)
        {
            tal /= cyckel.max;
            return tal;
        }
        public static Cyckel operator ==(Cyckel cyckel, int tal)
        {
            cyckel.max = tal;
            return cyckel;
        }
        public static Cyckel operator !=(Cyckel cyckel, int tal)
        {
            return cyckel;
        }
        public static Cyckel operator <(Cyckel cyckel, int tal)
        {
            return cyckel;
        }
        public static Cyckel operator >(Cyckel cyckel, int tal)
        {
            return cyckel;
        }

        public override string ToString()
        {
            return $"Val: {Val}, Min: {min}, Max: {max}";
        }
    }
}
