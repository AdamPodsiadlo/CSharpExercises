using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEx.Basics
{
    public class PropertyOperations
    {
        public int Value { get; set; }

        public PropertyOperations(int value)
        {
            Value = value;

        }

        public void Increment()
        {
            Value = Value + 1;
            

        }

        public void Decrement()
        {
            Value = Value - 1;

        }

        public void Clear()
        {
            Value = Value - Value;

        }

        public void Square()
        {
            Value = Value * Value;
        }
    }
}
