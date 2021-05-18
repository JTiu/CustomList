using System;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            //var town names


            NM_Towns a = new NM_Towns("Mesilla", 1);
            NM_Towns b = new NM_Towns("Las Cruces", 2);
            NM_Towns c = new NM_Towns("Bernalillo", 3);
            NM_Towns d = new NM_Towns("Roswell", 4);
            NM_Towns e = new NM_Towns("Portales", 5);
            NM_Towns f = new NM_Towns("Santa Fe", 6);
            NM_Towns g = new NM_Towns("El Paso", 7);
            NM_Towns h = new NM_Towns("ABQ", 8);
            NM_Towns[] smallTowns =
            {
                a,b,c,d,e,f,g,h
            };

            foreach (NM_Towns iterationVariable1 in smallTowns)
                Console.WriteLine($"{iterationVariable1.Name}, has {iterationVariable1.Population}");
            Console.ReadLine();

            NM_Towns aTown = smallTowns[3];
            NM_Towns anotherTown = smallTowns[4];
            Console.WriteLine($"{aTown.Name} has {aTown.Population} population: index [3]");
            Console.WriteLine($"{anotherTown.Name} has {anotherTown.Population} population: index [4]");
            NM_Towns lastTown = smallTowns[smallTowns.Length - 1];

            Console.WriteLine();
            Console.WriteLine($"The last town is {lastTown.Name}");
            Console.WriteLine(smallTowns[3]);
            Console.WriteLine(smallTowns[4]);
            Console.WriteLine(smallTowns[5]);
            Console.WriteLine(smallTowns[6]);


            Console.ReadLine();

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
                route31,
                new BusRoute(32, "Hatch", "Las Cruces"),
                new BusRoute(34, "Hatch", "Mesilla")
            };

            Console.WriteLine(route40);
            Console.WriteLine(route42);
            Console.WriteLine(route44);

            Console.WriteLine();
            foreach (BusRoute iterationVariable2 in routes)
                Console.WriteLine(iterationVariable2.Origin);
            Console.ReadLine();
            Console.Clear();
            for (int everyItemInArray = 0; everyItemInArray < smallTowns.Length; everyItemInArray++)
            Console.WriteLine($"Prints all {smallTowns[everyItemInArray]} at index[{everyItemInArray}]");
            Console.ReadLine();

        }
    }
}
