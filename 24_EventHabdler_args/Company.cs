using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_EventHabdler_args
{
    class MyArgs: EventArgs
    {
        public string Description { get; set; }
        public DateTime Date => DateTime.Now;
    }
    internal class Company
    {
        public string Name { get; set; }
        public event EventHandler<MyArgs> NewPosition;
        public void AddPosition(string description)
        {
            MyArgs args = new MyArgs() { Description = description};
            NewPosition?.Invoke(this, args);
        }
    }
}
