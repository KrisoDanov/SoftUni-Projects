using _3._Telephony.Exceptions;
using System;

namespace _3._Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phones = Console.ReadLine().Split();
            string[] webSite = Console.ReadLine().Split();

                    StationaryPhone stationaryPhone = new StationaryPhone();
            Smartphone smartphone = new Smartphone();
            for (int i = 0; i < phones.Length; i++)
            {
                if (phones[i].Length == 7)
                {
                    Console.WriteLine(stationaryPhone.Dialing(phones[i]));
                }
                if (phones[i].Length == 10)
                {
                    Console.WriteLine(smartphone.Calling(phones[i]));
                }
                
            }
            for (int i = 0; i < webSite.Length; i++)
            {
                Console.WriteLine(smartphone.Browsing(webSite[i]));
            }
        }
    }
}
