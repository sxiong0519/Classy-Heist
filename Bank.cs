using System;

namespace HeistII_Oceans5
{
    public class Bank
    {
        public double CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }
        public bool IsSecure
        {
            get
            {
                return AlarmScore + VaultScore + SecurityGuardScore > 0;
            }
        }

        public string MostSecure
        {
            get
            {
                if (AlarmScore > VaultScore && AlarmScore > SecurityGuardScore)
                {
                    return "Alarm";
                }
                else if (VaultScore > AlarmScore && VaultScore > SecurityGuardScore)
                {
                    return "Vault";
                }
                else
                {
                    return "Security Guard";
                }

            }

        }
        public string LeastSecure
        {
            get
            {
                if (AlarmScore < VaultScore && AlarmScore < SecurityGuardScore)
                {
                    return "Alarm";
                }
                else if (VaultScore < AlarmScore && VaultScore < SecurityGuardScore)
                {
                    return "Vault";
                }
                else
                {
                    return "Security Guard";
                }

            }
        }
        public void ReconReport()
        {
        Console.WriteLine($"Most Secure: {MostSecure}");
        Console.WriteLine($"Least Secure: {LeastSecure}");
        
        }
    }
}