using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practise.stringformating
{
    internal class StringFormatExcercise
    {
        public static void stringFormatExcercise1()
        {
            string projectName = "ACME";

            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

            Console.WriteLine($"View English output:\n\tc:\\Exercise\\{projectName}\\dara.txt\n{russianMessage}: \n\tc:\\Excersice\\{projectName}\\ru-Ru\\data.tsx");
        }
        
    }
}
