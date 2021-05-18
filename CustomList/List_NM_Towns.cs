using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class NM_Towns
    {
        //var
        public string Name { get; }
        public int Population { get; }
           
        //ctor
        public NM_Towns(string cityName, int cityPop)
        {
            this.Name = cityName;
            this.Population = cityPop;
        }

        //can do
        //public override string ToString() => $"Town:{Name}";

    }
}
