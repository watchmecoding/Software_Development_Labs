using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Mechanism : MyObject, IUse, IPlay
    {
        public int ManufactureYear { get; set; }
        public string Provider { get; set; }
        public string CountryProvider { get; set; }
        public Mechanism(string name, int manufactureyear, string provider, string country)
        {
            this.Name = name;
            this.ManufactureYear = manufactureyear;
            this.Provider = provider;
            this.CountryProvider = country;
        }
        public void ToUse()
        {
            System.Console.WriteLine("Seems like a ready-to-use Mechanism");
        }

        public void Play()
        {
            ToUse();
        }
       
    }
}
