using System;

namespace HarmonicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            while (true)
            {
                Console.WriteLine("Please enter a number");
                N = Convert.ToInt32(Console.ReadLine());
                if (N != 0)
                {
                    HarmonicNumber(N);
                    break;
                }
                else if (N == 0)
                {
                    continue;
                }
            }

        }
        static void HarmonicNumber( int N)
        {
            int count = 1;
            while (count <= N)
            {
                if (count < N)
                {
                    Console.Write("1/{0}+", count);
                }
                else if (count == N)
                {
                    Console.Write("1/{0}", count);
                }
                count++;
            }
        }
    }
}
