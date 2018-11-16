using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class Claim
    {

    
        public int ClaimID { get; set; }
        public string ClaimType { get; set; }
        public string ClaimDesc { get; set; }
        public string DamageAmount { get; set; }
        public string AccidentDate { get; set; }
        public string ClaimDate { get; set; }
        public string IsValid { get; set; }
    

        public Claim(int claimID, string claimType, string claimDesc, string damageAmount, string accidentDate, string claimDate, string isValid)
        {
            ClaimID = claimID;
            ClaimType = claimType;
            ClaimDesc = claimDesc;
            DamageAmount = damageAmount;
            AccidentDate = accidentDate;
            ClaimDate = claimDate;
            IsValid = isValid;
        }

        public Claim()
        {

        }
    }
}
