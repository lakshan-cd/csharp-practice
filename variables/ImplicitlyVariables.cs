using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practise.variables
{
    internal class ImplicitlyVariables
    {
        private static void printImplicitlyVariables()
        {
            var message = "Hellow World!"; //have to implicitly asign value to the variable  , will act as a string variable because of the value assigned to it
            Console.WriteLine(message);
        }
    }
}
