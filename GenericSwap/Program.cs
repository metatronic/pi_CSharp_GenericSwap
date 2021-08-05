using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine($"num 1: {num1} num2: {num2}");
            SwapGeneric<int>.Swap(ref num1, ref num2);
            Console.WriteLine($"num 1: {num1} num2: {num2}");


            double numd1 = 10.1;
            double numd2 = 20.2;
            Console.WriteLine($"num 1: {numd1} num2: {numd2}");
            SwapGeneric<double>.Swap(ref numd1, ref numd2);
            Console.WriteLine($"num 1: {numd1} num2: {numd2}");

            Console.ReadLine();

        }
    }
}
