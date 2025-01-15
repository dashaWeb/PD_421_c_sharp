using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_EventHabdler_args
{
    internal class Interviwer
    {
        public string Name { get; set; }
        public void DoSomething(object sender, MyArgs args)
        {
            Console.WriteLine($"Interviwer {Name} notified about {args.Description} Date :: {args.Date.ToShortDateString()} {args.Date.ToShortTimeString()}");
        }
    }
}
