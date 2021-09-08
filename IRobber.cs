using System;

namespace HeistII_Oceans5
{

    public interface IRobber
    {

        string Name { get; set; }
        int SkillLevel { get; set; }
        string Specialty { get; }

        int PercentageCut { get; set; }

        void PerformSkill(Bank bank);



    }
}