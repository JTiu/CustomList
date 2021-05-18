using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class BusRoute
    {
        //var
        public int Number { get; }
        public string Origin { get; }
        public string Destination { get; }

        public BusRoute(int number, string origin, string destination)
        {
            this.Number = number;
            this.Origin = origin;
            this.Destination = destination;
        }
        //method
        public override string ToString() => $"{Number}: starts in {Origin} goes to -> {Destination}";

    }


}
