using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_IClonable
{
    internal class Student : ICloneable
    {
        public string Name { get; set; }
        private int[] marks;

        public Student(string name = "NoName", int numMarks = 5)
        {
            Name = name;
            this.marks = new int[numMarks];
        }
        public Student(string name, params int[] marks)
        {
            Name = name;
            this.marks = (int[] )marks.Clone();
        }
        public override string ToString()
        {
            return $"Name :: {Name} -- Marks :: {String.Join<int>(", ", marks)}";
        }

        public object Clone()
        {
            return new Student(Name, this.marks);
        }

        public int this[int index] {
            get => marks[index];
            set => marks[index] = value >=0 && value <= 12 ? 
                value : 
                throw new ArgumentOutOfRangeException($"Bad value for mark {value}");
        }

    }
}
