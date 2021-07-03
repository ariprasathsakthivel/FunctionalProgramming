using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year in the format YYYY");
            int year = Convert.ToInt32(Console.ReadLine());
            LeapYearCheck(year);
        }
        static void LeapYearCheck(int year)
        {
            if ((year%400) == 0)
            {
                Console.WriteLine(year +"is a Leap year");
            }
            else if ((year%100) == 0)
            {
                Console.WriteLine(year +"is a non-leap year");
            }
            else if ((year%4) == 0)
            {
                Console.WriteLine(year +"is a Leap year");
            }
            else
            {
                Console.WriteLine(year +"is a non-leap year");
            }
        }
    }
}
