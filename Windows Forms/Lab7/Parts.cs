using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Parts : Mechanism
    {
        public string Material { get; set; }
        public int Amount { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }

        public Parts(string name, int manufactureyear, string provider, string country,
            string material, int amount,  int width, int length) : base(name, manufactureyear,
                provider, country)
        {
            this.Material = material;
            this.Amount = amount;
            this.Width = width;
            this.Length = length;
        }
        public override string ToString()
        {
            string res = $"Назва деталі:{Name}, Рік виробництва: {ManufactureYear}, Виробник: {Provider}, Країна походження: " +
                $"{CountryProvider}, Кількість в партії: {Amount}, Матеріал: {Material}," +
                $" Ширина: {Width}, Довжина: {Length}";
            return res;
        }
    }
}
