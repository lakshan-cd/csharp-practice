using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practise.variables
{
    internal class Excersice1
    {
        public static void printWord()
        {
            string name = "Bob";
            int count = 3;
            float temperature = 36.50f;

            Console.WriteLine("Hello," + name + "!" + " You have " + count + " messages in your inbox. The temperature is " + temperature + " celsius.");
        }
    }
}