//This is the first part of the CS 407 Lab 1 by Tyler Amaral using C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TylerAmaralLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 30;		//Loop for 30 times
            int imin = 0;
            double error;
            double y;
            double x = 0.5;
            double h = 1;
            double emin =1;
            
            for(int i = 1; i < n; i++)
            {
                h = h * 0.25;
                y = ((Math.Sin(x + h)- Math.Sin(x))/h);	//Derivative for sin of x
                error = Math.Abs((Math.Cos(x) - y));	//calculates the rate of error by checking with cosine because derivative of sin is cosine.

                Console.WriteLine("Value for i =\t" + i);
                Console.WriteLine("Value for h =\t" + h);
                Console.WriteLine("Value for y =\t" + y);
                Console.WriteLine("Value for error = " + error);
                Console.WriteLine();
                if (error < emin)
                {
                    emin = error;
                    imin = i;
                }

               
            }
			//For 30 iterations, as the h gets closer and closer to 0, the precision goes out the window
			//That is why the error gets so much bigger until it has a high error rate.
            Console.WriteLine("Value for imin =\t" + imin);
            Console.WriteLine("Value for emin =\t" + emin);

        }
    }
}
