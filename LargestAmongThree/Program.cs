using System;

namespace LargestAmongThree
{
    class Program
    {
        static void Main(string[] args)
        {
            arrayCreation();
        }
        static void arrayCreation()
        {
            int[] threeNumbers = new int[3];
            for (int i=0; i<3; i++)
            {
                Console.WriteLine("Enter the " + (i + 1) + " number");
                threeNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Reverse(threeNumbers);
            Console.WriteLine("Largest number among three numbers is : {0}",threeNumbers[0]);
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
