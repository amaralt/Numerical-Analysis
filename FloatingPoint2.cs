using System;
//Created by Tyler Amaral

namespace Lab3AmaralPartB
{
    class Program
    {
        public static void functions(double num)
        {
            double f;   //f(x) function
            double g;   //g(x) function
            double h;   //h(x) function

            for (double i = 1; i<=num; i++)
            {
                f = 1 / i;      //1/n
                g = f + 1 / (i-1);      //f(n)+1/ (n-1)
                h = i * f;          //i * 1/i and it should return all 1's

                //Pretty way to print it all out.
                Console.WriteLine("{0} \t {1:#.####} \t {2:#.####} \t {3:#.####}", i, f, g, h);
            }

        }

       

        static void Main(string[] args)
        {
            double n = 50;
            Console.WriteLine("I \t F \t G \t H");
            functions(n);
        }
    }
}
