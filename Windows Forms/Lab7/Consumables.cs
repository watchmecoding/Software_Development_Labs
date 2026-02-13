using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Consumables : Mechanism, IWork
    {
        public string CMaterial { get; set; }
        public string CAddInfo { get; set; }
        public double CWidth { get; set; }
        public double CLength { get; set; }
        public Consumables(string name, int manufactureyear, string provider, string country,
            string cMaterial, string cAddInfo, double cWidth, double cLength) : base(name, manufactureyear,
                provider, country)
        {
            this.CMaterial = cMaterial;
            this.CAddInfo = cAddInfo;
            this.CWidth = cWidth;   
            this.CLength = cLength;
        }
        public void DoWork()
        {
            System.Console.WriteLine("Consumables are being  used");
        }
        public bool Equals(Consumables cons)
        {
            return (cons.ManufactureYear == this.ManufactureYear && cons.CMaterial == this.CMaterial &&
                cons.CWidth == this.CWidth && cons.CLength == this.CLength && cons.CAddInfo ==
                this.CAddInfo && cons.CountryProvider == this.CountryProvider && cons.Provider == this.Provider
                && cons.Name == this.Name);
        }
        public override string ToString()
        {
            string res = $"Назва: {Name}, Рік виробництва: {ManufactureYear}, Виробник: {Provider}, Країна: " +
                $"{CountryProvider}, Матеріал: {CMaterial}, Доп. інформація про виріб: {CAddInfo}, Ширина: " +
                $"{CWidth}, Довжина: {CLength}";
            return res;
        }
    }
}
