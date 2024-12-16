using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Static___class
{
    enum Position
    {
        None, Manager =1, Developer, QA, Economist, Director
    }
    internal class Employee
    {
        private static int lastId;
        public readonly int ID = ++lastId; // readonly поле тільки для читання, встановлюється значення один раз (у конструкторі або тут)
        public string Name { get; set; } = "NoName";
        public DateTime Birth { get; set; }
        public Position Position { get; set; }
        public static int LastId { get => lastId; }
        public static bool SamePOsition(Employee e1, Employee e2)
        {
            return e1.Position == e2.Position;
        }
        static Employee() // без параметрів, спрацює до перщого використання класу
        {
            Console.WriteLine("\t\t Static ctor done");
            lastId = new Random().Next(1,10) * 1000;
        }
        public override string ToString()
        {
            return $"ID : {ID,-5} Name : {Name,-10} Birth : {Birth.ToShortDateString(),-15} Position : {Position}";
        }
        public int Age { get => (int)((DateTime.Today - Birth).TotalDays / 365.25); }
    }
}
