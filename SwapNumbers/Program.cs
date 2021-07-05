using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            NumberSwap(firstNumber, secondNumber);
        }
        static void NumberSwap(int firstNumber, int secondNumber)
        {
            int temp; //temporary variable for storing the value
            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
            Console.WriteLine("Swaping process is completed");
            Console.WriteLine("First Number : {0}", firstNumber);
            Console.WriteLine("Second Number : {0}", secondNumber);
        }
    }
}
