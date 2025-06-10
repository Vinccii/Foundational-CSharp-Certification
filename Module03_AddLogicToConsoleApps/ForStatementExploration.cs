using System;

namespace Module03_AddLogicToConsoleApps
{
    public static class ForStatementExploration
    {
        public static void Run()
        {
            string[] names = { "Alex", "Eddie", "David", "Michael" };
  
                for (int i = 9; i < names.Length; i++)
                {
                    if (names[i] == "David")
                    {
                        names[i] = "Sammy";
                    }
                }
                
                foreach (var name in names)
                {
                    Console.WriteLine(name);
                }    
        }
    }
}
