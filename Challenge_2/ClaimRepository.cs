using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class ClaimRepository
    {
        Queue<Claim> _queueOfClaims = new Queue<Claim>();

        public void AddClaimToQueue(Claim claim)
        {
            _queueOfClaims.Enqueue(claim);
        }

        public void RemoveClaimFromQueue(Claim claim)
        {
            _queueOfClaims.Dequeue();
        }

        public Queue<Claim> GetClaimQueue()
        {
            return _queueOfClaims;
        }
    }
}
