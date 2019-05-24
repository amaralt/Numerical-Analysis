using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15Amaral
{
    class Lab15Amaral
    {
        static void Romberg(Func<double, double> f, double a, double b, int n, double[,] r)
        {
            int i, j, k;
            double h, sum;
            h = b - a;
            r[0, 0] = (h / 2)*(f(a) + f(b));
            for (i = 1; i < n; i++)
            {
                h = h / 2;
                sum = 0;
                for (k = 1; k < (Math.Pow(2, i)-1); k++)
                {
                    sum = sum + f(a + k * h);
                }
                r[i, 0] = ((1 / 2) * r[i - 1, 0]) + (sum) * h;
                for (j = 1; j < i; j++)
                {
                    r[i, j] = r[i, j - 1] + (r[i, j - 1] - r[i - 1, j - 1]) / (Math.Pow(4, j) - 1);
                }
            }
            
        
        }

        static double aandb(double x)
        {
            return 4/(1+(Math.Pow(x,2)));
        }

        static double c(double x)
        {
            return Math.Sin(x) / x;
        }

        static void Main(string[] args)
        {
            int n = 20; //Increases accuracy
            double[,] r = new double[n,n];
            Romberg(aandb, 0,2, n, r);
            Console.WriteLine(r[n-1, n - 2]);
            Console.WriteLine("Wolfram says 4.428");
            Romberg(aandb, 0, 1, n, r);
            Console.WriteLine(r[n - 1, n - 2]);
            Console.WriteLine("Wolfram says 3.14159");
            Romberg(c, 1.3, 2.19, n, r);
            Console.WriteLine(r[n - 1, n - 2]);
            Console.WriteLine("Wolfram says 0.49997");

        }
    }
}
