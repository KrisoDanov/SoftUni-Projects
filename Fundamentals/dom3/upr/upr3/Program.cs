using System;

namespace upr3
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLenght = int.Parse(Console.ReadLine());
            int[] arr = new int[1025];
            for (int i = 0; i < arrLenght; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }

            int counter = 1;

            int max = 0;

            int element = 0;
            for (int i = 0; i < arr.Length – 1; i++)

        

                if (arr[i] == arr[i + 1])

                {
                    counter++;
                }

                else

                {

                    counter = 1;

                }

                if (max < counter)

                {

                    max = counter;

                    element = array[i];

                }

            

        }

    }
}

    

