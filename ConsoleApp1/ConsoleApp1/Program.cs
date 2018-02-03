using System;

namespace ConsoleApp1
{
    class Program
    {
        static void soart (double a, double b, double c)
        {
            double S = (a + b +c) / 2;
            S = Math.Sqrt(S * (S - a) * (S - b) * (S - c));
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
           double a, b, R, c;
           int x;
            char T;
                Console.WriteLine("for find square of a right triangle - write 1");
                Console.WriteLine("for find area of ​​a circle along its radius - write 2");
                x = int.Parse(Console.ReadLine()); 

            if (x == 1)
            {
                Console.WriteLine("Write a, b, c");
                Console.Write("Write a =  ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Write b =  ");
                b = double.Parse(Console.ReadLine());
                Console.Write("Write c =  ");
                c = double.Parse(Console.ReadLine());
                Console.Write("square of a right triangle equals = "); 
                soart (a, b,c);
                Console.WriteLine();
                Console.WriteLine("Click any kay for exit or click 'R' for repeat");
                T = char.Parse(Console.ReadLine());
                if ((T == 'R') || (T == 'r'))
                {
                    Main();
                }
                if (T != 'R')
                {
                    Environment.Exit(0);
                }
            }
                if (x == 2)
                {
                    Console.WriteLine("Wrire R");
                    Console.WriteLine("Write a =  ");
                    R = double.Parse(Console.ReadLine());
                    Console.Write("area of circle along equals = ");
                    aoacar(R);
                    Console.WriteLine();
                    Console.WriteLine("Click any kay for exit or click 'R' for repeat");
                    T = char.Parse(Console.ReadLine());
                    if ((T == 'R')||(T=='r'))
                    {
                    Main();
                    }
                    if (T != 'R') 
                    {
                    Environment.Exit(0);
                    }
                }

                if (x != 1 & x != 2)
                {
                    Console.WriteLine("ERROR. Write 1 or 2");
                    Main();
                }
             
        }
    }
}
