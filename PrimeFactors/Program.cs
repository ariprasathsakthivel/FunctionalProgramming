using System;

namespace PrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for finding prime factors");
            int N = Convert.ToInt32(Console.ReadLine());
            PrimeFactors(N);
        }
        static void PrimeFactors(int N)
        {
            int flag = 0;
            for (int i = 2; i <= N; i++)
            {
                if ((N % i) == 0)
                {
                    flag = 1;
                    for (int j = 2; j < i; j++)
                    {
                        if ((i % j) == 0)
                        {
                            flag = 0;
                            break;
                        }
                    }
                    if (flag == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
