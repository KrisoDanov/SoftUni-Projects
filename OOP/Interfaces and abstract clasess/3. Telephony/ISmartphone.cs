using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._Telephony
{
    public interface ISmartphone
    {
        public string Calling(string number);

        public string Browsing(string url);
        
    }
}
