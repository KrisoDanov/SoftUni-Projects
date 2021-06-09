using _3._Telephony.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._Telephony
{
    public class Smartphone : ISmartphone
    {
        public string Browsing(string url)
        {
            if (url.Any(x => char.IsDigit(x)))
            {
                try
                {
                    throw new IvalidURLException();
                }
                catch (InvalidPhoneNumberException e)
                {

                    Console.WriteLine(e.Message);
                }

            }
            return $"Browsing... {url}";
        }

        public string Calling(string number)
        {
            if (!number.All(x => char.IsDigit(x)))
            {
                try
                {
                    throw new InvalidPhoneNumberException();
                }
                catch (InvalidPhoneNumberException e)
                {

                    Console.WriteLine(e.Message);
                }
            }
            return $"Calling... {number}";
        }
    }
}
