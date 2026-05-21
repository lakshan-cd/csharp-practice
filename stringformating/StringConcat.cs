using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practise.stringformating
{
    internal class StringConcat
    {
        public static void stringConcat()
        {
            // String CONCATENATION

            string firstName = "Bob";
            string message = "Hello " + firstName;
            Console.WriteLine(message);

            Console.WriteLine();
            string firstNameM = "Bob";
            string greetingM = "Hello";
            string messageM = greetingM + " " + firstNameM + "!";
            Console.WriteLine(message);


            //without intermeditate variable
            Console.WriteLine("Hellow" + firstNameM + " " + greetingM);
        }
    }
}
