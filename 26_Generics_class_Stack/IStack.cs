using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Generics_class_Stack
{
    interface IStack<T> //: IEnumerable<T>
    {
        void Push(T value);
        void Pop();
        T Peek();
        int Count { get; }
    }
}
