using System;

namespace Module03_AddLogicToConsoleApps
{
    public static class SentenceSplitChallenge
    {
        public static void Run()
        {
            string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad",
                "I like all three of the menu choices" };
            int stringsCount = myStrings.Length;

            string myString = "";
            int periodLocation = 0;

            for (int i = 0; i < stringsCount; i++)
            {
                myString = myStrings[i];
                periodLocation = myString.IndexOf(".");

                string mySentence;

                // extrahiert Sätze von jedem String und zeigt sie einer nach dem anderem
                while (periodLocation != -1)
                {
                    
                    // Der erste Satzt ist der string value links vom Ort des ersten Punkts
                    mySentence = myString.Remove(periodLocation);

                    // der rest von myStrings ist der string value rechts vom Ort
                    myString = myString.Substring(periodLocation + 1);

                    // entfernt white-space von myString
                    myString = myString.TrimStart();

                    // updated den Ort des Kommas und erhöht den Zähler
                    periodLocation = myString.IndexOf(".");

                    Console.WriteLine(mySentence);
                }

                mySentence = myString.Trim();
                Console.WriteLine(mySentence);

                
            }
        }
    }
}
