using System;

namespace T03.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num;

            int prineSum = 0;
            int nonPrimeSum = 0;
            bool isPrime;

            while (input != "stop")
            {
                num = int.Parse(input);
                isPrime = true;
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            nonPrimeSum = nonPrimeSum + num;
                            break;
                        }
                    }
                    if (isPrime == true)
                    {
                        prineSum = prineSum + num;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {prineSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
