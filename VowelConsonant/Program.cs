using System;

namespace VowelConsonant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a letter in small case to check for vowel");
            char a = Convert.ToChar(Console.ReadLine());
            VowelOrConsonant(a);
        }
        static void VowelOrConsonant(char a)
        {
            int flag = 0;
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            foreach (char element in vowels)
            {
                if (a == element)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("{0} is a vowel", a);
            }
            else
            {
                Console.WriteLine("{0} is a consonant", a);
            }
        }
    }
}
