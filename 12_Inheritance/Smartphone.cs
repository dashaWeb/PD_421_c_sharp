using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Inheritance
{
    public class Smartphone :Device
    {
        public bool HasBattery { get; } = true;
        public Smartphone(string brand = "NoBrand", int year = 2000, bool hasBattery = true) 
            :base(brand,year)
        {
            HasBattery = hasBattery;
        }
        public /*sealed*/ override void Print()
        {
            Console.WriteLine($"{this.GetType().Name} --->  Brand :: {Brand,-10} Year :: {Year,-10} Battery :: {HasBattery}");
        }
        public override string ToString()
        {
            return base.ToString() + $"Battery :: {HasBattery}";
        }
        public void Call()
        {
            Console.WriteLine("Is calling work");
        }
    }
}
