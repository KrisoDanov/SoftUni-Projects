using System;
using System.Collections.Generic;
using System.Text;

namespace dom1
{
    public class Box<T>
    {
        public Box(T value)
        {
            Value = value;
        }
        public T Value { get; set; }

        public override string ToString()
        {
            return $"{this.Value.GetType()}: {Value}";
        }
    }
}
