using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Inheritance
{
    public abstract class Device
    // abstract - клас; 1) не можна створити обєкт класу; 2) можна працювати з похідними типами через посилання на абстрактний клас
    {
        protected string brand; // буде видно у дочірному класі
        public string Brand
        {
            get => brand;
            set => brand = value ?? "Nobrand";
        }
        private int year;
        public int Year
        {
            get => year;
            set
            {
                year = value <= DateTime.Today.Year ? value : 2024;
            }
        }
        public Device(string brand = "Nobrand",  int year = 2024)
        {
            Brand = brand;
            Year = year;
        }
        internal int Price { get; set; }
        protected internal int Weight { get; set; }
        //public virtual void Print();
        public abstract void Print();
        public override string ToString()
        {
            return $"{this.GetType().Name,-10} Brand :: {brand,-10} Year :: {year,-10} Price :: {Price,-10} Weight :: {Weight,-10}";
        }
    }
}
