using System;

namespace RelativelyPrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskNod.Input();
            TaskNod.BinaryAlgorithm(TaskNod.n, TaskNod.m, TaskNod.k);
            TaskNod.Output();

            Console.ReadKey();
        }
    }

    class TaskNod
    {
        static public int n;
        static public int m;
        static public int k = 1;

        static public void Input()
        {
            Console.Write("Enter 2 whole numbers\n 1st number = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write(" 2st number = ");
            m = Convert.ToInt32(Console.ReadLine());
        }

        static public double BinaryAlgorithm(int n, int m, int k)
        {
            if (n != 0 && m != 0)
            {
                if (n % 2 == 0 && m % 2 == 0)
                {
                    n /= 2;
                    m /= 2;
                    k *= 2;
                    return BinaryAlgorithm(n, m, k);
                }
                else if (n % 2 == 0 && m % 2 != 0)
                {
                    n /= 2;
                    return BinaryAlgorithm(n, m, k);
                }

                else if (n % 2 != 0 && m % 2 == 0)
                {
                    m /= 2;
                    return BinaryAlgorithm(n, m, k);
                }
                else if (n >= m)
                {
                    n -= m;
                    return BinaryAlgorithm(n, m, k);
                }
                else
                {
                    m -= n;
                    return BinaryAlgorithm(n, m, k);
                }

            }
            else return m * k;
        }

        static public void Output()
        {
            if (BinaryAlgorithm(n, m, k) == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Numbers {0} and {1} are mutually simple, because their NOD = 1 ", n, m);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Numbers {0} and {1} are not mutually simple, because their NOD != 1 ", n, m);
            }
        }

    }
}
