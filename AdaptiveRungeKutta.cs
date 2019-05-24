using System;

namespace Lab22Part4
{
    class Lab22Problem4
    {

        static void Rk45(Func<double, double, double> f,ref double t, ref double x, ref double h,ref double epil)
        {
            double k1, k2, k3, k4, k5, k6, x4;
            //This is the area where RK45 needs to have these values, so it can calculate it effectively.
            double c20 = 0.25;
            double c21 = 0.25;

            double c30 = 0.375;
            double c31 = 0.09375;
            double c32 = 0.28125;

            double c40 = 12.0 / 13.0;
            double c41 = 1932.0 / 2197.0;
            double c42 = -7200.0 / 2197.0;
            double c43 = 7296.0 / 2197.0;

            double c51 = 439.0 / 216.0;
            double c52 = -8.0;
            double c53 = 3680.0 / 513.0;
            double c54 = -845.0 / 4104.0;

            double c60 = 0.5;
            double c61 = -8.0 / 27.0;
            double c62 = 2.0;
            double c63 = -3544.0 / 2565.0;
            double c64 = 1859.0 / 4104.0;
            double c65 = -0.275;

            double a1 = 25.0 / 216.0;
            double a2 = 0;
            double a3 = 1408.0 / 2565.0;
            double a4 = 2197.0 / 4104.0;
            double a5 = -0.2;

            double b1 = 16.0 / 135.0;
            double b2 = 0;
            double b3 = 6656.0 / 12825.0;
            double b4 = 28561.0 / 56430.0;
            double b5 = -0.18;
            double b6 = 2.0 / 55.0;
            //This is where the math comes in.

            k1 = h * f(t, x);
            k2 = h * f(t + c20 * h, x + c21 * k1);
            k3 = h * f(t + c30 * h, x + c31 * k1 + c32 * k2);
            k4 = h * f(t + c40 * h, x + c41 * k1 + c42 * k2 + c43 * k3);
            k5 = h * f(t + h, x + c51 * k1 + c52 * k2 + c53 * k3 + c54 * k4);
            k6 = h * f(t + c60 * h, x + c61 * k1 + c62 * k2 + c63 * k3 + c64 * k4 + c65 * k5);
            x4 = x + a1 * k1 + a3 * k3 + a4 * k4 + a5 * k5;
            x = x + b1 * k1 + b3 * k3 + b4 * k4 + b5 * k5 + b6 * k6;
            t = t + h;
            epil = Math.Abs(x - x4);
        }

        static double f(double t, double x)
        {
            //problem1
            return 2.0 + Math.Pow((x - t - 1.0), 2);
            
        }

        static double f2(double t, double x)
        {
            return 3.0+5.0*Math.Sin(t)+0.2*x;
        }

        static double sign(double x)
        {
            if (x >= 0)
            {
                return 1.0;
            }

            else
            {
                return -1.0;
            }


        }

        static void Main(string[] args)
        {
            //given values
            int k;
            double t, h, epil;
            double a = 1;
            double b = 1.5625;
            double x = 2.0;
            double n = 72;
            epil = 0.000005;

            h = (b - a) / n;
            t = a;
            Console.WriteLine("0\t{0}\t{1}", t, x);
            Console.WriteLine("k\tt\tx\tepil");
            for (k = 0; k < n; k++)
            {
                //Needs to be a pass by reference
                Rk45(f,ref t,ref x,ref h,ref epil);
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", k, t, x, epil);
            }

        }
    }
}
