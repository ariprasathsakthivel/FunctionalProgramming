using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for checking even or odd");
            int N = Convert.ToInt32(Console.ReadLine());
            OddEven(N);
        }
        static void OddEven(int N)
        {
            if ((N%2)==0)
            {
                Console.WriteLine("The number {0} is a Even number", N);
            }
            else
            {
                Console.WriteLine("The number {0} is an Odd number", N);
            }
        }
    }
}
