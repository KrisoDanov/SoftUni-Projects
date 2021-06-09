using System;
using System.Collections.Generic;
using System.Text;

namespace _3._Telephony.Exceptions
{
    public class IvalidURLException : Exception
    {
        private const string INVALID_URL_EXCEPTION_MESSAGE = "Invalid URL!";
        public IvalidURLException()
            :base(INVALID_URL_EXCEPTION_MESSAGE)
        {

        }
    }
}
