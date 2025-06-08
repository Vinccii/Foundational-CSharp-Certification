using System;

namespace Module03_AddLogicToConsoleApps
{
    public static class Challenge01
    {
        public static void Run()
        {
            Console.WriteLine("Hallo ich bin Vincent 😄");
            Console.Write("Gib eine Zahl ein: ");
            int zahl = Convert.ToInt32(Console.ReadLine());

            if (zahl % 2 == 0)
            {
                Console.WriteLine("Gerade Zahl!");
            }
            else
            {
                Console.WriteLine("Ungerade Zahl!");
            }
        }
    }
}
