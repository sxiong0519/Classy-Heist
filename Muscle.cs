using System;

namespace HeistII_Oceans5
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore -= SkillLevel 
            Console.WriteLine($"{Name} is knocking out the guards! Decreased security {SkillLevel} points.");
            if (bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine($"{Name} has knocked out the guards!");
            }
        }
    }
}