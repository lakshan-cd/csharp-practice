using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practise.stringformating
{
    internal class StringConcatIntepolation
    {
        public static void pringUsingInterpolation()
        {
            string firstName = "Bob";
            string greeting = "Hello";
            string message = $"{greeting} {firstName}";
            Console.WriteLine(message);


            string messageWithText = $"Testttt {firstName}!";
            Console.WriteLine(messageWithText);


            int version = 11;
            string updateText = "Update to Windowss";
            string messageWithVersion = $"{updateText} {version}";
            Console.WriteLine(messageWithVersion);

            string projectName = "First-Project";
            Console.WriteLine($@"C:\Output\{projectName}\Data");
        }
    }
}
