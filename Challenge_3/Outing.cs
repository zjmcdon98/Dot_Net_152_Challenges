using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public enum OutingType { Concert = 1, Movie = 2, Ballgame = 3, Error = 4}
    class Outing
    {
        public OutingType TypeOfOuting { get; set; }
        public int AtendeeAmount { get; set; }
        public string OutingDate { get; set; }
        public decimal AtendeeCost { get; set; }
        public decimal OutingCost { get; set; }

        public Outing(OutingType typeOfOuting, int atendeeAmount, string outingDate, decimal atendeeCost, decimal outingCost)
        {
            TypeOfOuting = typeOfOuting;
            AtendeeAmount = atendeeAmount;
            OutingDate = outingDate;
            AtendeeCost = atendeeCost;
            OutingCost = outingCost;
        }

        public Outing()
        {

        }
    }
}
