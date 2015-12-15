using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structisar
{
    /*
    * struct
    * en egendefinierad värdetyp
    * har inga referenser till heapen
    * är implicit sealed
    * är public per default
    * skrivs som vi skriver en klass men med nyckelordet struct
    * alla de primitiva typerna är structar
         ex: int, long, double, float, char, DateTime
    * ungefär tre gånger snabbare änr en klass om 5 fält finns
    * Kan inte vara null, pga av kan inte referera till heapen


    */


    struct Koordinat
    {
        public int X;
        public int Y;
        public string Z;
        
        //public int Z = 0; //Does not compute, vi får inte sätta värde på fält i en struct
        public override string ToString()
        {
            return $"X: {X}, Y: {Y}, Z: {Z}"; 
        }
    }
    //struct StructXYZ : Koordinat
    //{
         //Kan och får inte ärva från en struct
    //}
}
