using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableNgnting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa en POCO-klass med 3 attribut
            //Lägg 5 av klassen i en kollektion
            //Använd sort på kollektionen
            //Skriv ut kollektionen
            var lista = new List<ThreeAttributes>();
            lista.Add(new ThreeAttributes(23, 12, 11));
            lista.Add(new ThreeAttributes(33, 4, 13));
            lista.Add(new ThreeAttributes(214, 42, 1));
            lista.Add(new ThreeAttributes(2, 1, 21));
            lista.Add(new ThreeAttributes(13, 41, 13));
            lista.Sort();
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
