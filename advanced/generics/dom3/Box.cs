using System;
using System.Collections.Generic;
using System.Text;

namespace dom3
{
    class Box<T> where T : IComparable
    {
        public Box(List<T> values)
        {
            this.Values = values;
        }
        public List<T> Values { get; set; }

        public int Compare(T value)
        {
            int counter = 0;
            foreach (T item in Values)
            {
                if (value.CompareTo(item) < 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
