using System;

namespace Module04_WorkWithVariableDataInC_ConsoleApplications
{
    public static class ExamineTheTryParse__MethodExersice
    {
        public static void Run()
        {
            /*string value = "102";
            int result = 0;
            if (int.TryParse(value, out result))
            {
                Console.WriteLine($"Measurement: {result}");
            }
            else
            {
                Console.WriteLine("Unable to report the measurement.");
            }
            Console.WriteLine($"Measurement (w/ offset): {50 + result}");*/

            string value = "bad";
            int result = 0;
            if (int.TryParse(value, out result))
            {
                Console.WriteLine($"Measurement: {result}");
            }
            else
            {
                Console.WriteLine("Unable to report the measurement.");
            }

            if (result > 0)
                Console.WriteLine($"Measurement (w/ offset): {50 + result}");
        }
    }
}
