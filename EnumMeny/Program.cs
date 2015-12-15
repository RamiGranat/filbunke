using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumMeny
{
    class Program
    {

        enum Menu { AddItem, LoseItem, CreateSome, Awesome, Avsluta }
        static void Main(string[] args)
        {
            int tal;
            Console.WriteLine("Skriv 0-4");
            if (int.TryParse(Console.ReadLine(), out tal))
            {
                Menu menu = (Menu)tal;
                switch (menu)
                {
                    case Menu.AddItem:
                        Console.WriteLine(Menu.AddItem);
                        break;
                    case Menu.LoseItem:
                        Console.WriteLine(Menu.LoseItem);
                        break;
                    case Menu.CreateSome:
                        Console.WriteLine(Menu.CreateSome);
                        break;
                    case Menu.Awesome:
                        Console.WriteLine(Menu.Awesome);
                        break;
                    case Menu.Avsluta:
                        Console.WriteLine(Menu.Avsluta);
                        break;
                    default:
                        throw new MemberAccessException();
                }
            }
        }
    }
}
