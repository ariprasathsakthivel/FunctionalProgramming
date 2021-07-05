using System;

namespace QuotientRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int divident, divisor;
            Console.WriteLine("Enter the divident");
            divident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the divisor");
            divisor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quotient is : {0}", Quotient(divident, divisor));
            Console.WriteLine("Reminder is : {0}", Reminder(divident, divisor));
        }
        static int Quotient(int divident, int divisor)
        {
            return divident / divisor;
        }
        static double Reminder(double divident, double divisor)
        {
            return divident % divisor;
        }
    }
}
