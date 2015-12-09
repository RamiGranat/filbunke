using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konverteringar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Konverteringar();
            Cyckel c1 = new Cyckel(); //OK!
            MC mc = new Cyckel(); //Ej OK
            MC mc2 = (MC) c1; //Explicit typkonvertering
            //Kompilatorn upptäcker inte felet föränn under programkörning

            //TEST
            Cyckel cyckel = (Cyckel) new MC();
            MC mcTest = c1 as MC; //Försöker göra om c1 till en MC, om den lyckas blir den en MC
                                //om den misslyckas blir den en null
            if (mcTest != null) //Kontrollerar att mc är giltig
            {
                //Konverterad
            }
            //Test med is:
            Object obj = new Cyckel();
            bool b = obj is Cyckel; //Always true
            Cyckel cyckel2 = new Cyckel();
            Boolean f = cyckel2 is object;

            //Boxing:
            int tal = 5;
            object paket = tal; //Boxing - värdetyp till referenstyp

            //Unboxing:
            int tal23 = (int)paket; //Unboxing- referenstyp till värdetyp
        }

        private static void Konverteringar()
        {
            long tal = 200; //Implicit typkonvertering
            //int tal2 = 200L;
            int tal2 = (int)200L; //Explicit typkonvertering (Extra!)
            System.Int64 longTal = 200L;
            System.Int32 intTal = 200;
            var doubleTal = 4.4;
            //float floatTal = (float)4.4; //Typkonvertering
            float flytTal = 4.4f; //Ingen typkonvertering
            int number = (int)doubleTal;
            //Alltid när vi gör explicit typkonvertering kan vi FÖRLORA något
            //Om ve gör en implicit typkonvetering är den nya behållaren "större" så vi får plats med allt

        }
    }
}
