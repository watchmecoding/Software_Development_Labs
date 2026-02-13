using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_7_TRPZ
{
    public abstract class MyObject: IInformation
    {
        public abstract void GetInformationInConsole();
        public abstract void GetInformationInWindow();
        public abstract string GetInformation();
    }
}
