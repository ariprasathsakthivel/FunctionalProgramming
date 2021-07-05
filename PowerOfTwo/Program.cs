using System;
using static System.Math;

namespace PowerOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            while (true)
            {
                Console.WriteLine("Please enter a value N");
                N = Convert.ToInt32(Console.ReadLine());
                if (N >= 0 && N < 31)
                {
                    PowerOfTwo(N);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        static void PowerOfTwo(int N)
        {
            double count = 0;
            double powers = 0;
            double baseNumber = 2;
            if (N == 0)
            {
                Console.WriteLine("2 to the power of " + N + " : 1");
            }
            else
            {
                while (count < N)
                {

                    powers = Math.Pow(baseNumber, (count + 1));
                    Console.WriteLine("2 to the power of " + (count + 1) + " : {0}", powers);
                    count++;
                }
            }
        }
    }
}
