using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwap
{
    static class SwapGeneric<T>
    {
        public static void Swap(ref T num1, ref T num2)
        {
            T temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}
