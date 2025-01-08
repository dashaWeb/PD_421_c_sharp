using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Interface
{
    class Duck:IMove, IFly,ISwim
    {
        //1) одна реалізація для всіх інтерфейсів
        //public int Speed => 3; // неявна реалізація інтерфейсу (для кого явно не вказано, то буде обрано компілятором)
        //2) явна реалізація
        public int Weight { get; set; }
        int IMove.Speed => 3;
        int IFly.Speed => 10;

        public virtual void Fly()
        {
            Console.WriteLine($"Duck can fly with {((IFly)this).Speed}");
        }

        public void Move()
        {
            Console.WriteLine($"Duck with weight {Weight} can walk with speed {((IMove)this).Speed}");
        }

        public void Swim()
        {
            Console.WriteLine("Duck can swim");
        }
    }
}
