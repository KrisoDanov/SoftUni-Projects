using _3._Telephony.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._Telephony
{
    public class StationaryPhone : IStationaryPhone
    {
        public string Dialing(string number)
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
            return $"Dialing... {number}";
        }
    }
}
