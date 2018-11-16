using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class OutingRepository
    {
        List<Outing> _listOfOutings = new List<Outing>();

        public void AddOutingToList(Outing outing)
        {
            _listOfOutings.Add(outing);
        }

        public List<Outing> GetOutingList()
        {
            return _listOfOutings;
        }
    }
}
