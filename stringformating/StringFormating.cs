using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practise.stringformating
{
    internal class StringFormating
    {
        public static void stringFormating()
        {
            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine("Hello\tWorld!");
            Console.WriteLine("Hello \"worlds\"!");
            Console.WriteLine("C:\\lakshan\\chamara");



            Console.WriteLine();


            Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.Write("\nOutput Directory:\t");
            Console.Write(@"c:\invoices");


            Console.WriteLine();

            //Verbatim string literal -> use @ before

            Console.WriteLine(@"                  hjhjhj

                            (Test hjkhkjhjhjh)");

            Console.WriteLine();

            //Unicode -> \u escape sequence, then a four-character code
            // Kon'nichiwa World
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

        }
    }
}
