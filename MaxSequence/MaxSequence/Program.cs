using System;
using System.Collections.Generic;

namespace MaxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_MaxSequence.Input();
            Task_MaxSequence.Solution(Task_MaxSequence.array);
            Console.ReadKey();
        }
    }

    class Task_MaxSequence
    {
        static int size_array = 7;
        static public int[] array = new int[size_array];        

        static public void Input()
        {
            Console.WriteLine("Enter array of {0} elements:",size_array);
            for(int i=0; i<size_array; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static public void Solution(int[]array)
        {
            int index_max = 0;
            int index_min = 0;
            bool flag = false;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[i - 1])
                {
                    if (flag == false)
                    {
                        index_min = i - 1;
                    }
                    index_max = i + 1;
                    flag = true;
                }
                else
                { flag = false; }
            }

            Console.Write("array[{0}]: ",size_array);
            for(int i=0; i < array.Length; i++)
            {
                Console.Write(" {0}", array[i]);
            }

            Console.Write("\nMaxSequence = ");
            for (int i = index_min; i < index_max; i++)
            {
                Console.Write(" {0}", array[i]);
            }
        }
    }
}
