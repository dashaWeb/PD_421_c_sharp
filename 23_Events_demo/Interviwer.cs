using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Events_demo
{
    internal class Interviwer // subscriber
    {
        public string Name { get; set; }

        // метод, що може бути обробником події (підходить під наш делегат PositionDelegate)
        public void DoSomething(string desc)
        {
            Console.WriteLine($"Interviwer {Name} notified adout {desc}");
        }
    }
}
