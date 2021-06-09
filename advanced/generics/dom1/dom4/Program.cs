using System;

namespace dom4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split();
            string name = input1[0] + " " + input1[1];
            string city = input1[2];
            string townn = input1[3];
            Tuple<string, string,string> town = new Tuple<string, string, string>(name, city, townn);
            Console.WriteLine(town);

            string[] input2 = Console.ReadLine().Split();
            string namee = input1[0];
            int litres = int.Parse(input2[1]);
            bool trueotnahh = true;
            Tuple<string, int, bool> output = new Tuple<string, int, bool>(namee, litres, trueotnahh);
            Console.WriteLine(output);

            string[] input3 = Console.ReadLine().Split();
            string integer = input3[0];
            double number = double.Parse(input3[1]);
            string money = input3[2];
            Tuple<string, double, string> outputt = new Tuple<string, double, string>(integer, number, money);
            Console.WriteLine(outputt);

        }
    }
}
