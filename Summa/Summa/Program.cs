using System;

namespace Summa
{
    class Program
    {
        static void Main(string[] args)
        {         
            SummaLargestSmallest.Input();
            SummaLargestSmallest.TaskSolution(SummaLargestSmallest.array);
            Console.ReadKey();
        }
    }

    class SummaLargestSmallest
    {
        static int array_size;
        static public int[] array;

        static public void Input()
        {
            Console.Write("Enter size massif: ");
            array_size = Convert.ToInt32(Console.ReadLine());
            array = new int[array_size];

            Console.WriteLine("Enter elements massif: ");            
            for (int i=0; i< array_size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

       static public void ArraySort (int[] array)
        {
            for(int i=0;i<array.Length; i++)
            {
                for (int j=i;j<array.Length;j++)
                {
                    if (array[i] < array[j])
                    {
                        array[i] += array[j];
                        array[j] = array[i] - array[j];
                        array[i] -= array[j];
                    }
                }
            }
        }

        static public void TaskSolution(int[]array)
        {
            ArraySort(array);
            Console.WriteLine("*** Solution ***");
            Console.WriteLine("The 2nd largest elements = {0}", array[1]);
            Console.WriteLine("The 2nd smallest element = {0}", array[array.Length - 2]);
            Console.WriteLine("The sum of the 2nd largest and 2nd smallest elements of the array = {0}", array[1] + array[array.Length - 2]);
        }
    }
}
