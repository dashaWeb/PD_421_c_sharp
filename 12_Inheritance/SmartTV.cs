using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Inheritance
{
    internal class SmartTV:TV
    {
        public SmartTV(string brand = "Nobrand", int year = 2024, int diagonal = 42)
            :base(brand,year,diagonal)
        {

        }
        new public void Print()
        {
            Console.WriteLine("Smart TV");
        }
    }
}
