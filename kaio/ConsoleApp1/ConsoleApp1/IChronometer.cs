using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IChronometer
    {
        public string GetTime { get; }

        public List<string> Laps { get; }

        void Start();

        void Stop();

        void Lap();

        void Reset();


    }
}
