using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Intro__class
{
    // видимість класу
    // public - відкритий для інших збірок
    // internal - закритий для інших збірок, видимий лише для своєї збірки
    internal class Character // неявно успадковується від суперкласу Object
    {
        // поля
        private string name = "Unknown";
        private uint hp = 100; // якщо не проініціалізувати поле, то буде значееня для типу пл замовчуванню, для посилальних типів null
        // методи
        public Character(string newName, uint hp, uint damage)
        {
            //this.name = name; // посилання на обєкт для якого працює метод
            name = newName;
            Damage= damage;
            this.hp = hp;
        }
        public Character(string name = "Unknown")
            : this(name, 100,0) // каскадно викликається конструктор цього ж класу з 2 параметрами
        { }
        public void Print()
        {
            Console.WriteLine($"Character name     :: {name}");
            Console.WriteLine($"Character hp       :: {hp}");
            Console.WriteLine($"Character damage   :: {hp}");
        }
        public override string ToString()
        {
            return $"Name :: {name,-10} HP :: {hp,-10} Damage :: {Damage,-10}";
        }
        public string Name
        {
            get { return name; }
            set
            {
                // value - ключове слово для set = значення яке хочемо встановити
                /*if(value.Length == 0)
                {
                    name = "Unknown";
                }
                else
                {
                    name = value ;
                }*/
                if (!String.IsNullOrWhiteSpace(value)) // якщо прийшло не пусте, не null , не "   " \t\n
                    name = value;
            }
        }
        public uint Damage { get; set; } = 10; // авто властивість, компілятор створить поле типу uint та для нього get, set 
        public uint KPD
        { // property тільки для читання, бо визначили лише get
            /*get
            {
                //return hp * Damage;
            }*/
            get => hp * Damage;
        }
    }
}

