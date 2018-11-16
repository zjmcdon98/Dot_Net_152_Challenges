using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class ProgramUI
    {
        OutingRepository _outingRepo = new OutingRepository();

        public void Run()
        {
            RunMenu();
        }

        public void RunMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Choose an option" +
                    "\n1. Show All Outings" +
                    "\n2. Add an Outing" +
                    "\n3. Show All Outing Costs" +
                    "\n4. Show Outing Costs by Type" +
                    "\n5. Exit");


                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        ShowAllOutings();
                        break;

                    case 2:
                        AddNewOuting();
                        break;

                    case 3:
                        ShowAllOutingCosts();
                        break;

                    case 4:
                        ShowCostsByType();
                        break;

                    case 5:
                        isRunning = false;
                        Console.WriteLine("Thankyou!");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Invalid Response");
                        Console.ReadLine();
                        break;

                }
            }
        }

        public void ShowAllOutings()
        {
            List<Outing> outingList = _outingRepo.GetOutingList();
            foreach (Outing outing in _outingRepo.GetOutingList())
            {
                Console.WriteLine(outing.TypeOfOuting);
            }
        }

        public void AddNewOuting()
        {
            Outing newOuting = new Outing();
            Console.WriteLine("What is the Type of Outing? (1.Concert, 2.Movie, 3.Ballgame)");
            newOuting.TypeOfOuting = (OutingType)int.Parse(Console.ReadLine());

            Console.WriteLine("How many people attended?");
            newOuting.AtendeeAmount = int.Parse(Console.ReadLine());

            Console.WriteLine("What was the date of the outing?");
            newOuting.OutingDate = Console.ReadLine();

            Console.WriteLine("How much were each of the attendees charged?");
            newOuting.AtendeeCost = decimal.Parse(Console.ReadLine());

            Console.WriteLine("How much did the event cost?");
            newOuting.OutingCost = decimal.Parse(Console.ReadLine());

            _outingRepo.AddOutingToList(newOuting);
        }

        public void ShowAllOutingCosts()
        {
            decimal totalcost = 0;

            List<Outing> outingList = _outingRepo.GetOutingList();
            foreach (Outing outing in outingList)
            {
                totalcost += outing.OutingCost;
            }

            Console.WriteLine($"The Combined total Costs of the outtings are: {totalcost}");
        }

        public void ShowCostsByType()
        {
            decimal totalcostballgame = 0;
            decimal totalcostmovie = 0;
            decimal totalcostconcert = 0;

            List<Outing> outingList = _outingRepo.GetOutingList();
            foreach (Outing outing in outingList)
            {
                
                if(outing.TypeOfOuting == OutingType.Concert)
                {
                    totalcostconcert += outing.OutingCost;
                }
                else if(outing.TypeOfOuting == OutingType.Movie)
                {
                    totalcostmovie += outing.OutingCost;
                }
                else if(outing.TypeOfOuting == OutingType.Ballgame)
                {
                    totalcostballgame += outing.OutingCost;
                }
            }

            Console.WriteLine($"The Combined total Costs of the outtings for Concerts are: {totalcostconcert}");
            Console.WriteLine($"The Combined total Costs of the outtings for Movies are: {totalcostmovie}");
            Console.WriteLine($"The Combined total Costs of the outtings for Ballgames are: {totalcostballgame}");

        }

        public OutingType parseOutingType(int number)
        {
            switch (number)
            {
                case 1:
                    return OutingType.Concert;
                case 2:
                    return OutingType.Movie;
                case 3:
                    return OutingType.Ballgame;
                default:
                    return OutingType.Error;
                    
                
            }
        }
        
    }
}



