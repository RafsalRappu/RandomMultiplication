using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RandomMultiplication
{
    class Program
    {
        static void Multiplication(int N, int i)
        {
            Thread.Sleep(500);
            if (i > 1)
                return;
            Console.WriteLine( + i + " X " + +N + " = " + N * i);
            Multiplication(N, i+1 );
        }
        static void Multiplication2(int N, int i)
        {
            Thread.Sleep(500);
            if (i > 9)
                return;
            Console.WriteLine( + i + " X " + +N + " = " + N * i);
            Multiplication2(N, i + 1);
        }
        static void Multiplication3(int N, int i)
        {
            Thread.Sleep(500);
            if (i > 2)
                return;
            Console.WriteLine( + i + " X " + +N + " = " + N * i);
            Multiplication3(N, i + 1);
        }
        static void Multiplication4(int N, int i)
        {
            Thread.Sleep(500);
            if (i > 8)
                return;
            Console.WriteLine( + i + " X " + +N + " = " + N * i);
            Multiplication4(N, i + 1);
        }
        static void Multiplication5(int N, int i)
        {
            Thread.Sleep(500);
            if (i > 3)
                return;
            Console.WriteLine( + i + " X " + +N + " = " + N * i);
            Multiplication5(N, i + 1);
        }
        static void Multiplication6(int N, int i)
        {
            Thread.Sleep(500);
            if (i > 7)
                return;
            Console.WriteLine( + i + " X " + +N + " = " + N * i);
            Multiplication6(N, i + 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication table of 2 for random numbers");
            Console.WriteLine("\n");
            int N = 2;
            Multiplication(N, 1);
            Multiplication2(N, 9);
            Multiplication3(N, 2);
            Multiplication4(N, 8);
            Multiplication5(N, 3);
            Multiplication6(N, 7);

            Console.WriteLine("\n");
            Console.WriteLine("Click any key to exit");
            Console.ReadKey();
        }
    }
}
