using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practise.aithmeticoperation
{
    internal class IncrementDecrement
    {
        public static void printIncrementDecrement()
        {
            int value = 1;

            value = value + 1;
            Console.WriteLine("First increment: " + value);

            value += 1;
            Console.WriteLine("Second increment: " + value);

            value++;
            Console.WriteLine("Third increment: " + value);

            value = value - 1;
            Console.WriteLine("First decrement: " + value);

            value -= 1;
            Console.WriteLine("Second decrement: " + value);

            value--;
            Console.WriteLine("Third decrement: " + value);
        }
    }
}
