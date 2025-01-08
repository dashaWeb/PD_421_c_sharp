using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Interface
{
    // interface - може містити методи, властивості, індексатори, події, static field, const
    interface IMove
    {
        int Speed { get; }
        void Move();
    }
}
