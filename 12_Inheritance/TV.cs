using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Inheritance
{
    public class TV : Device
    {
        public int Diagonal { get; set; } = 42;
        public TV(string brand = "Nobrand", int year = 2024, int diagonal = 42) 
            :base(brand,year)
        {
           Diagonal= diagonal;
        }

        public sealed override void Print()
        {
            Console.WriteLine($"{this.GetType().Name} --->  Brand :: {Brand,-10} Year :: {Year,-10} Diagonal :: {Diagonal}");
        }
        public  override string ToString()
        {
            return base.ToString() + $"Diagonal :: {Diagonal}";
        }
        public void NextChannel()
        {
            Console.WriteLine("Next Channel work");
        }
    }
}
