using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void soart (double a, double b)
        {
            double S = (a * b) / 2;
            Console.Write(S);
        }
        static void aoacar(double R)
        {
            double pi =Math.PI;
            double S = pi * (R * R);
            Console.Write(S);
        }
        static void Main()
        {
           double a, b, R;
           int x;
                Console.WriteLine("for find square of a right triangle - write 1");
                Console.WriteLine("for find area of ​​a circle along its radius - write 2");
                x = int.Parse(Console.ReadLine()); 

            if (x == 1)
            {
                Console.WriteLine("Write a, b");
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());

                Console.Write("square of a right triangle equals = "); 
                soart (a, b);
                Console.WriteLine();
                Console.WriteLine("Click any kay for exit");
                Console.ReadLine();
            }
                if (x == 2)
                {
                    Console.WriteLine("Wrire R");
                    R = double.Parse(Console.ReadLine());
                    Console.Write("area of circle along equals = ");
                    aoacar(R);
                    Console.WriteLine();
                    Console.WriteLine("Click any kay for exit");
                    Console.ReadLine();
                }

                if (x != 1 & x != 2)
                {
                    Console.WriteLine("ERROR. Write 1 or 2");
                    Main();
                }
             
        }
    }
}
