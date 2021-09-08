using System;
using System.Collections.Generic;

namespace HeistII_Oceans5
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank newBank = new Bank
            {
                AlarmScore = new Random().Next(0, 101),
                VaultScore = new Random().Next(0, 101),
                SecurityGuardScore = new Random().Next(0, 101),
                CashOnHand = new Random().Next(50000, 1000001)
            };
            // Console.WriteLine($"{newBank.MostSecure} & {newBank.LeastSecure} & {newBank.AlarmScore} & {newBank.VaultScore} & {newBank.SecurityGuardScore} & {newBank.CashOnHand} & {newBank.IsSecure}");
            newBank.ReconReport();


            List<IRobber> rolodex = new List<IRobber>{
                new Hacker {Name = "Fingers", SkillLevel = 20, PercentageCut = 10},
                new LockSpecialist {Name = "Lockin Lakin", SkillLevel = 75, PercentageCut = 20},
                new Muscle {Name = "BigGuns", SkillLevel = 45, PercentageCut = 25},
                new Hacker { Name ="Hardison", SkillLevel = 10, PercentageCut = 7},
                new LockSpecialist { Name = "Parker", SkillLevel = 15, PercentageCut = 10},
                new Muscle { Name = "Eliot", SkillLevel = 20, PercentageCut = 12},
                new Hacker {Name = "Kwik Tips", SkillLevel = 55, PercentageCut = 20},
                new LockSpecialist {Name = "Randy", SkillLevel = 30, PercentageCut = 15},
                new Muscle {Name = "Bane", SkillLevel = 40, PercentageCut = 33}
            };
            CreateMember();
            void CreateMember()
            {
                Console.WriteLine($"{rolodex.Count}");
                Console.WriteLine("Name of the new crew member:");
                string memberName = Console.ReadLine();
                if (memberName != "")
                {
                    Console.WriteLine("What is their specialty? 1)Hacker 2)Lock Specialist 3)Muscle");
                    int memberSpecialty = int.Parse(Console.ReadLine());
                    List<string> specialty = new List<string>{
                    "Hacker", "Lock Specialist", "Muscle"
                };
                    Console.WriteLine("Enter crew member's skill level between 1 and 100.");
                    int memberSkillLevel = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter requested percentage cut.");
                    int memberPercentageCut = int.Parse(Console.ReadLine());

                    if (memberSpecialty == 1)
                    {
                        rolodex.Add(new Hacker { Name = memberName, SkillLevel = memberSkillLevel, PercentageCut = memberPercentageCut });
                    }
                    else if (memberSpecialty == 2)
                    {
                        rolodex.Add(new LockSpecialist { Name = memberName, SkillLevel = memberSkillLevel, PercentageCut = memberPercentageCut });
                    }
                    else
                    {
                        rolodex.Add(new Muscle { Name = memberName, SkillLevel = memberSkillLevel, PercentageCut = memberPercentageCut });
                    }
                    CreateMember();

                }
                int i = -1;
                foreach (var member in rolodex)
                {
                    // i++;
                    Console.WriteLine($"{i++}, {member.Name}, {member.Specialty}, {member.SkillLevel}, {member.PercentageCut}.");
                }

            }




        }
    }
}
