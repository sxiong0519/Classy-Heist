using System;
using System.Collections.Generic;

namespace HeistII_Oceans5
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }

        public int PercentageCut { get; set; }


        public void PerformSkill(Bank bank)
        {

            Console.WriteLine($"{Name} has a skill of {SkillLevel} and demands {PercentageCut} from the total take ");
        }
    }
}