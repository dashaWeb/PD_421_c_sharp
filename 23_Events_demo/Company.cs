using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Events_demo
{
    delegate void PositionDelegate(string description); // 1) визначили тип делегату для події NewPosition(нова вакансія) у класі Company
    class Company // Publisher
    {
        public string Name { get; set; }
        public event PositionDelegate NewPosition; // 2) подія = екзкмпляр делегату
        public void AddPosition(string description) // метод для бізнес логіки
        {
            NewPosition?.Invoke(description); // 4) ініціювання (запуск) події 
            // NewPosition ---- виклик методів приєднаних до делегату
        }
    }
}
