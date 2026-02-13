using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_7_TRPZ
{
    // Інтерфейс для отримання інформації про тварину
    public interface IInformation
    {
        public void GetInformationInConsole();
        public void GetInformationInWindow();
    }

    // Інтерфейс для взаємодії з методами руху
    public interface IMovable
    {
        void Move();
    }

    // Інтерфейс для взаємодії з голосовою комунікацією
    public interface ISound
    {
        void MakeSound();
    }
}
