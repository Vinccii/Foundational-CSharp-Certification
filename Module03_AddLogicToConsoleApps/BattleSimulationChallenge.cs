using System;

namespace Module03_AddLogicToConsoleApps
{
    public static class BattleSimulationChallenge
    {
        public static void Run()
        {
            Random random = new Random();

            int heroHealth = 10;
            int monsterHealth = 10;
            int damage = random.Next(1, 11);

            do
            {
                damage = random.Next(1, 11);
                Console.WriteLine("The Hero attacks!");
                monsterHealth -= damage;
                Console.WriteLine($"Monster was damaged and lost {damage} health points and now has {monsterHealth} health points left");
                
                if (monsterHealth > 0)
                {
                    Console.WriteLine("The Monster attacks!");
                    damage = random.Next(1, 11);
                    heroHealth -= damage;
                    Console.WriteLine($"Hero was damaged and lost {damage} health points and now has {heroHealth} health points left");
                }
                
            } while (heroHealth > 0 && monsterHealth > 0);
            
            if (heroHealth > 0)
                Console.WriteLine("Monster wins");
            else if (monsterHealth > 0)
                Console.WriteLine("Hero wins!");
        }
    }
}
