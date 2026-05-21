using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practise.aithmeticoperation
{
    internal class DivisionPractice
    {
        public static void divisionPrint()
        {
            decimal decimalQuotient = 7.0m / 5;
            Console.WriteLine($"Decimal quotient: {decimalQuotient}");

            decimal decimalQuotient1 = 7 / 5.0m;
            Console.WriteLine($"Decimal quotient 1: {decimalQuotient1}");

            decimal decimalQuotient2 = 7.0m / 5.0m;
            Console.WriteLine($"Decimal quotient 2: {decimalQuotient2}");

            decimal decimalQuotientAdecimalQuotientD = 7 / 5;
            Console.WriteLine($"Decimal quotient 3: {decimalQuotientAdecimalQuotientD}");

            //cast data  to decimal
            int first = 10;
            int second = 4;
            Console.WriteLine($" division of int : {((decimal)first / (decimal)second)}");

        }
    }
}
