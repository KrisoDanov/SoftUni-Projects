using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Chronometer 
    {
        private string getTime;
        private List<string> laps;

        public string GetTime => getTime;

        public List<string> Laps => laps;

        public void Lap(Stopwatch timer, List<string> laps)
        {
            Console.WriteLine(timer);
            laps.Add(timer.ToString());
        }

        public void Reset(Stopwatch timer)
        {
            timer.Reset();
        }

        public void Start(Stopwatch timer)
        {
            timer.Start();
        }

        public void Stop(Stopwatch timer)
        {
            timer.Stop();
        }

    }
}
