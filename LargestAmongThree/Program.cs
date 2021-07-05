using System;

namespace LargestAmongThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] threeNumbers = arrayCreation();
            Console.WriteLine(threeNumbers);
        }
        static int[] arrayCreation()
        {
            int[] threeNumbers = new int[3];
            for (int i=0; i<3; i++)
            {
                Console.WriteLine("Enter the "+ (i+1) +"number");
                threeNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            return threeNumbers;
        }
    }
}
