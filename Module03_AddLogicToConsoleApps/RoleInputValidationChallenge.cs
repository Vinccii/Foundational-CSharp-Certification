using System;

namespace Module03_AddLogicToConsoleApps
{
    public static class RoleInputValidationChallenge
    {
        public static void Run()
        {
            string? readResult;
            string role = "";
            bool validRole = false;

            do
            {
                Console.WriteLine("Bitte gib deine Rolle ein (Administrator, Manager, oder User):");
                readResult = Console.ReadLine();

                if (readResult != null)
                {
                    role = readResult.Trim().ToLower(); // Leerzeichen weg, alles klein

                    if (role == "administrator" || role == "manager" || role == "user")
                    {
                        validRole = true;
                    }
                    else
                    {
                        Console.WriteLine($"Die Rolle \"{readResult}\" ist ungültig. Bitte versuch es erneut.");
                    }
                }
            } while (!validRole);
            Console.WriteLine($"Deine Rolle \"{role}\" wurde akzeptiert.");
        }
    }
}
