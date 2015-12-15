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
            /*abstract tvingar subklasser att ta hand om vad det nu är som är abstract genom en override
            virtual får man välja själv om man vill använda den eller göra en bätter
            override skriver över något
            ToString gör en sträng som representerar klassen*/

            //Lisat1();
            //Lista2();
            //BusList();
            //PlaneList();
            //ClearList();
            //ArraySyntaxIntisar();
            //IndexOfMethod();
            //AirPlaneList();

            int minNumber;
            List<Fruit> fruitList = new List<Fruit>();
            for (int i = 0; i < 3; i++)
            {
            Console.WriteLine("Write a name for your fruit");
                var name = Console.ReadLine();
                Console.WriteLine("Write the number of your fruit in storage");
                var antal = int.Parse(Console.ReadLine());
            fruitList.Add(new Fruit(name, antal));
            }
            Console.WriteLine("Write a minimum number to print");
            minNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < fruitList.Count; i++)
            {
                if (minNumber <= fruitList[i].Number)
                    Console.WriteLine(fruitList[i]);
            }
        }

        private static void AirPlaneList()
        {
            AirPlane airPlane1 = new AirPlane(54, 3);
            AirPlane airPlane2 = new AirPlane(32, 2);
            AirPlane airPlane3 = new AirPlane(4, 1);
            List<AirPlane> planeList = new List<AirPlane>();
            planeList.Add(airPlane1);
            planeList.Add(airPlane2);
            planeList.Add(airPlane3);
            planeList.Sort();
            foreach (var plane in planeList)
            {

                Console.WriteLine(plane);
            }
        }

        private static void IndexOfMethod()
        {
            List<int> tal = new List<int>(new int[] { 3, 2, 3, 2, 29, 33, 32 });

            int indexPosition = tal.IndexOf(29);
            Console.WriteLine(indexPosition);
            indexPosition = tal.IndexOf(17);
            Console.WriteLine(indexPosition);
        }

        private static void ClearList()
        {
            List<Boolean> lista = new List<bool>() { true, false, false, true };
            lista.Add(true);
            lista.Add(false);
            lista.Add(true);
            lista.Add(true);
            Console.WriteLine(lista.Count);
            lista.Clear();
            Console.WriteLine(lista.Count);
        }

        private static void ArraySyntaxIntisar()
        {
            var storlekar = new List<int>() { 32, 325, 5324, 6425, 352, 5324 };
            var kopia = storlekar;
            storlekar.Sort();
            //storlekar.Reverse();
            //foreach (var s in kopia)
            //{
            //    Console.WriteLine(s);
            //}
            for (int i = 0; i < storlekar.Count; i++)
            {
                Console.WriteLine(storlekar[i]);
            }
        }

        private static void PlaneList()
        {
            var jas39 = new AirPlane(5, 2);
            var jas40 = new AirPlane(7, 0);
            jas39.Seats = 5;
            var planes = new List<AirPlane>() { jas39, jas40 };
        }

        private static void BusList()
        {
            var busses = new List<Bus>();
            for (int i = 0; i < 10; i++)
            {
                busses.Add(new Bus(8 + i, 900));
            }
            foreach (var bus in busses)
            {
                Console.WriteLine(bus);
            }
        }

        private static void Lista2()
        {
            var persons = new List<Person>();
            for (int i = 0; i < 10000; i++)
            {
                persons.Add(new Person("Name" + i, i % 21));
            }

            //var myndiga = persons.Where(p => p.Age >= 18).ToList();

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
        }

        private static void Lisat1()
        {
            var lisa = new Person("Lisa", 26);
            var raffe = new Person("Rafael", 44);
            List<Person> persons = new List<Person>();
            persons.Add(lisa);
            persons.Add(raffe);
            foreach (var person in persons)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}
