using System;

namespace Module04_WorkWithVariableDataInC_ConsoleApplications
{
    public static class CombineStringArrayValuesAsStringsAndIntergersExercise
    {
        public static void Run()
        {
            string[] values = { "12.3", "45", "ABC", "11", "DEF" };

            double total = 0;
            string message = "";

            foreach (string value in values)
            {
                if (double.TryParse(value.Replace(".", ","), out double number))
                {
                    total += number;

                }
                else
                {
                    message += value;
                }
            }

            Console.WriteLine($"message: {message}");
            Console.WriteLine($"Todal: {total}");
        }
    }
}
