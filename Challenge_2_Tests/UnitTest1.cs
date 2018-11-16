using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_2_Tests
{
    [TestClass]
    public class ClaimTests
    {
        [TestMethod]
        public void Claim_SetID_ShouldBeCorrectInt()
        {
            //--Arrange
            Claim claim = new Claim();
            claim.ClaimID = "1";
        }
    }
}
            
            

           
