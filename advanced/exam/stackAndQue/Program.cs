using System;
using System.Collections.Generic;
using System.Linq;

namespace stackAndQue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputTask = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] inputAnswear = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            Stack<int> answear = new Stack<int>(inputTask);
            Queue<int> task = new Queue<int>(inputAnswear);
            Stack<int> otg = new Stack<int>();
            
            int currentAnswear = answear.Peek();
            int currentTask = task.Peek();

            while (currentAnswear != n)
            {
                if (currentAnswear <= currentTask)
                {
                    otg.Push(currentTask);
                    answear.Pop();
                    task.Dequeue();
                    currentAnswear = answear.Peek();
                    currentTask = task.Peek();
                }
                else
                {
                    task.Dequeue();
                    currentTask = task.Peek();
                }
            }
            Console.Write($"Thread with value {task.Peek()} ");
            Console.WriteLine($"killed task {n}");
            
            foreach (var item in task)
            {
                Console.Write(item + " ");
            }
        }
    }
}
