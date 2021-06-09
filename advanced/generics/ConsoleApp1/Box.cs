using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Box<T>
    {
        public Box(List<T> values)
        {
            Values = values;
        }
        public List<T> Values { get; set; }

        public void Swap(int firstIndex, int secondIndex)
        {
            T temp = this.Values[firstIndex];
            this.Values[firstIndex] = this.Values[secondIndex];
            this.Values[secondIndex] = temp;
            
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (T item in this.Values)
            {
                stringBuilder.AppendLine(($"{item.GetType()}: {item}"));
                Console.WriteLine();
            }
            return stringBuilder
                .ToString()
                .TrimEnd();
        }
    }
}
