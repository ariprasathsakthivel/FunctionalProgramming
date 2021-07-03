using System;

namespace FlipCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number for number of times to flip a coin");
            int count = Convert.ToInt32(Console.ReadLine());
            CoinPercentage(count);
        }
        static void CoinPercentage(int count)
        {
            double headCount = 0;
            double tailCount = 0;
            double countForPercentage;
            countForPercentage = count;
            while (count >= 0)
            {
                count--;
                Random random = new Random();
                int coin = random.Next(0, 2);
                if (coin == 0)
                {
                    tailCount++;
                }
                else if (coin == 1)
                {
                    headCount++;
                }
            }
            Console.WriteLine("Tail percentage : {0}", (tailCount / countForPercentage) * 100);
            Console.WriteLine("Head percentage : {0}", (headCount / countForPercentage) * 100);
        }   
    }
}
