//Lab 1 in C# by Tyler Amaral
using System;
using System.Linq;

namespace Lab1
{
    class Chebyshev
    {
        static void Main()
        {
            //These arrays contain all of the permutations of the name Chevyshev
            string[] beginning = new string[] { "Qeb", "Cheb", "Ceb", "Tscheb", "Tcheb" };
            string[] middle = new string[] { "i", "y" };
            string[] ending = new string[] { "shev", "cev", "cheff", "schef", "scheff" };

            //These for loops iterate through the three arrays
            for (int x = 0; x < beginning.Length; x++)
            {
                for (int y = 0; y < middle.Length; y++)
                {
                    for (int z = 0; z < ending.Length; z++)
                    {
                        //Prints the suckah out.
                        Console.WriteLine(beginning[x] + middle[y] + ending[z]);
                    }
                }
            }
        }
    }
}