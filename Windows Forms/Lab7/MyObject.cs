using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    abstract class MyObject
    {
        public string Name { get; set; }
        public void ShowName()
        {
            System.Console.WriteLine(this.Name);
        }
    }
}
