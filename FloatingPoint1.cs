using System;

namespace AmaralLab3A
{
    class AmaralLab3PartA
    {
        
        static void Main(string[] args)
        {
            double epsid = 1;
            float epsif = 1;
            long epsil = 1;
            long n = 2;

            //The functions below are the same with the only difference being the representation of the value.
            //The function is based off of the pseudocode, but basically is a do while loop, where you check to see if 1 + epsilon is still greater than 1
            //And if it is, then you divide by 2 and retry that calculation. It will give you a really small number.
            do { epsid /= 2.0d; }
            while ((double)(1.0 + epsid) != 1.0);
            Console.WriteLine("Calulated Machine Epsilon for Double is {0}", epsid);

            do { epsif /= 2.0f; }
            while ((float)(1.0 + epsif) != 1.0);
            Console.WriteLine("Calulated Machine Epsilon for float is {0}", epsif);

            do { epsil /= n; }
            while ((long)(1.0 + epsil) != 1.0);
            Console.WriteLine("Calulated Machine Epsilon for long is {0}", epsil);



        }
    }
}
