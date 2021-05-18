using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {

            //The learning objectives are to use and better understand generics, TDD, operator overloading, how arrays work, how a List<T> works under the hood, properties, fields, custom iterators

            //https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-5.0

            BusRoute route40 = new BusRoute(40, "Mesilla", "Portales");
            BusRoute route42 = new BusRoute(42, "Las Cruces", "Bernalillo");
            BusRoute route44 = new BusRoute(44, "ABQ", "Roswell");
            BusRoute route31 = new BusRoute(31, "Santa Fe", "El Paso");
            BusRoute[] routes =
            {
                route44,
                route42,
                route40,
                route31
            };

            Console.WriteLine(route40);
            Console.WriteLine(route42);
            Console.WriteLine(route44);

            Console.WriteLine();
            foreach (BusRoute route in routes)
            {
                Console.WriteLine(route);
            }
            Console.ReadLine();

        }
    }
}
