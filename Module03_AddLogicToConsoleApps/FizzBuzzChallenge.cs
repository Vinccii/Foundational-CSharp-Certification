﻿using System;
using System.ComponentModel.Design;

namespace Module03_AddLogicToConsoleApps
{
    public static class FizzBuzzChallenge
    {
        public static void Run()
        {
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                        Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
            }
 
        }
    }
}
