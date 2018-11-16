using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class Test
    {
        List<Claim> _listOfClaims = new List<Claim>();

        public void AddClaimToList(Claim claim)
        {
            _listOfClaims.Add(claim);
        }

        public void RemoveClaimFromList(Claim claim)
        {
            _listOfClaims.Remove(claim);
        }

        public List<Claim> GetClaimList()
        {
            return _listOfClaims;
        }
    }
}
