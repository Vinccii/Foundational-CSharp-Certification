using System;
using System.ComponentModel.Design;

namespace Module03_AddLogicToConsoleApps
{
    public static class IntegerInputValidationChallenge
    {
        public static void Run()
        {
            string? readResult;
            int numericValue = 0;
            bool validNumber = false;

            do
            {
                Console.WriteLine("Bitte gib eine Zahl zwischen 5 und 10 ein:");
          
                readResult = Console.ReadLine();

                bool isNumber = int.TryParse(readResult, out numericValue);

                if (!isNumber)
                {
                    Console.WriteLine("Sorry, du hast keine gültige Zahl eingegeben, bitte versuch es nochmal.");
                }
                else if (numericValue < 5 || numericValue > 10)
                {
                    Console.WriteLine($"du hast {numericValue} eigegeben. Bitte gib eine Zahl zwischen 5 und 10 ein.");
                }
                else
                {
                    validNumber = true;
                }
                    

            } while (validNumber == false);

            Console.WriteLine($"Dein Wert ({numericValue}) wurde akzeptiert.");
          

        }
    }
}
