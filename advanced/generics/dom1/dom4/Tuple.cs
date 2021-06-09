using System;
using System.Collections.Generic;
using System.Text;

namespace dom4
{
    class Tuple<Titem, Titem2, Titem3>
    {
        public Tuple(Titem value1, Titem2 value2, Titem3 value3)
        {
            this.Value1 = value1;
            this.Value2 = value2;
            this.Value3 = value3;
        }
        public Titem Value1 { get; set; }
        public Titem2 Value2 { get; set; }
        public Titem3 Value3 { get; set; }

        public override string ToString()
        {
            return $"{Value1} -> {Value2} -> {Value3}";
        }
    }
}
