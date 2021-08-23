using System;

namespace Factorial_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int number,fact=1,fibo;
            Console.WriteLine("Enter a number for factorial and fibonacci term\n");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i=1;i<=number;i++)
            {
                fact = fact*i;
            }
            Console.WriteLine("factorial is:"+ fact);

            int n1 = 0, n2 = 1,n3;
            Console.WriteLine("Fibonacci series is: ");
            for (int i=1; i<number; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
