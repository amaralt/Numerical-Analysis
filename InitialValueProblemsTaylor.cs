using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Lab21Amaral
    {
        static void Main(string[] args)
        {
            int k;
            double h, t, x1, x2, x3, x4, x5;
            int n = 100000;
            double a = 1;
            double b = 2.77;
            double x = 0.20466341728915526943;
            h = (b - a) / n;
            t = a;
            Console.WriteLine("K\t T \t X");
            Console.WriteLine("0 \t {0} \t {1}", t, x);
            for (k = 1; k<=n; k++)
            {
                x1 = x + x * x;
                x2 = x1 + 2 * x * x1;
                x3 = x2 + 2 * x * x2 + 2 * x1 * x1;
                x4 = x3 + 2 * x * x3 + 6 * x1 * x2;
                x5 = 2 * x * x4 + x4 + 6 * x2 * x2 + 8 * x3 * x1;
                x = x + h * (x1 + 0.5 * h * (x2 + (1 / 3) * h * (x3 + 0.25 * h * (x4 + 0.2 * h * (x5)))));
                t = a + k * h;
                Console.WriteLine("{0}\t{1}\t{2}", k, t, x);
                
            }

            Console.WriteLine("Now we try the exact solution");
            
            double answer = (Math.Pow(Math.E, 2.77) / (16 - Math.Pow(Math.E, 2.77)));
    
            Console.WriteLine("{0}", answer);
            Console.WriteLine("Pretty Close with larger values of N");
        }
    }
}
