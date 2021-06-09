using System;
using System.Collections.Generic;
using System.Linq;

namespace dom2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ChangeList = 
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> List1 = new List<int>(ChangeList);

            string input = "";

            while (input != "end")
            {
                input = Console.ReadLine();
                string phr = "";
                string numToParse = "";
                int numberToFit = 0;


                if (input.Contains("Delete "))
                {
                    phr = "Delete";
                    numToParse = input.Remove(0, 6);
                    string[] subs = numToParse.Split(' ');
                    numberToFit = int.Parse(numToParse);

                    foreach(var item in List1)
                    {
                        
                        if (numberToFit == item)
                        {
                            ChangeList.Remove(numberToFit);
                        }
                       
                    }

                }
                else if (input.Contains("Insert "))
                {
                    int firstNum = 0;
                    int secondNum = 0;
                    int temp = 0;
                    phr = "Insert";
                    numToParse = input.Remove(0, 7);
                    string[] subs = numToParse.Split(' ');
                    secondNum = int.Parse(subs[1]);
                    firstNum = int.Parse(subs[0]);
                    ChangeList.Insert(secondNum, firstNum);
                    
                }
                
            }
            Console.WriteLine(string.Join(" ", ChangeList));
        }
    }
}
