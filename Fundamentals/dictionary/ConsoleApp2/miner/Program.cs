using System;
using System.Collections.Generic;

namespace miner
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> miner =
            new Dictionary<string, int>();

            string inputMine = Console.ReadLine();
            int inputQuentity = int.Parse(Console.ReadLine());

            while (inputMine != "stop")
            {
                if (miner.ContainsKey(inputMine))
                {
                    miner[inputMine] += inputQuentity;
                }

                if (!miner.ContainsKey(inputMine))
                {
                    miner.Add(inputMine, inputQuentity);
                }

                inputMine = Console.ReadLine();
                if (inputMine != "stop")
                {
                    inputQuentity = int.Parse(Console.ReadLine());
                }
               
            }
            foreach (var item in miner)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
