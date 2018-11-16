using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class ProgramUI
    {
        ClaimRepository _claimRepo = new ClaimRepository();

        public void Run()
        {
            RunMenu();
        }

        public void RunMenu()
        {
            bool isRunning = true;
            while (isRunning == true)
            {

                Console.WriteLine("Choose a menu item" +
                    "\n1. See all Claims" +
                    "\n2. Take Care of Next Claim" +
                    "\n3. Enter a new Claim" +
                    "\n4. Exit");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1: //See all Claims
                        ShowClaims();
                        break;
                    case 2: //Take Care of Next Claim
                        NextClaim();
                        break;
                    case 3: // Enter New Claim
                        NewClaim();
                        break;
                    case 4: // Exit
                        isRunning = false;
                        Console.WriteLine("Thank You!");
                        Console.WriteLine("Logging off...");
                        Console.ReadLine();
                        break;
                    default: // All else
                        Console.WriteLine("Input Invalid");
                        Console.ReadLine();
                        break;
                }
            }
        }

        public void ShowClaims()
        {
            Queue<Claim> claimQueue = _claimRepo.GetClaimQueue();
            foreach (Claim claim in _claimRepo.GetClaimQueue())
            {
                Console.WriteLine($"Claim ID: {claim.ClaimID}");
                Console.WriteLine($"Type of Claim: {claim.ClaimType}");
                Console.WriteLine($"Description of Claim: {claim.ClaimDesc}");
                Console.WriteLine($"Amount of Damage: ${claim.DamageAmount}");
                Console.WriteLine($"Date of Accident: {claim.AccidentDate}");
                Console.WriteLine($"Date of Claim: {claim.ClaimDate}");
                Console.WriteLine($"Is the claim Valid?: {claim.IsValid}");
            }
        }

        public void NextClaim()
        {
            Console.WriteLine("Here is the next claim");
            PrintNextClaim();

            Console.WriteLine("Do you want to deal with this claim now? (y/n)");
            string choice = Console.ReadLine();
            string input = (choice);
            if( choice == "y")
            {
                RemoveClaim();
            }
            if(choice == "n")
            {
                RunMenu();
            }
        }

        public void PrintNextClaim()
        


        {
            Queue<Claim> claimQueue = _claimRepo.GetClaimQueue();
            Claim claim =  claimQueue.Peek();
            Console.WriteLine(claim);
            Console.WriteLine();
            
            Console.WriteLine($"Claim ID: {claim.ClaimID}");
            Console.WriteLine($"Type of Claim: {claim.ClaimType}");
            Console.WriteLine($"Description of Claim: {claim.ClaimDesc}");
            Console.WriteLine($"Amount of Damage: ${claim.DamageAmount}");
            Console.WriteLine($"Date of Accident: {claim.AccidentDate}");
            Console.WriteLine($"Date of Claim: {claim.ClaimDate}");
            Console.WriteLine($"Is the claim Valid?: {claim.IsValid}");

            Console.WriteLine();
        }

        public void RemoveClaim()
        {
            Queue<Claim> claimQueue = _claimRepo.GetClaimQueue();
            Claim claim = claimQueue.Dequeue();
        }

        public void NewClaim()
        {
            Claim newClaim = new Claim();
            Console.WriteLine("Enter the claim id");
            newClaim.ClaimID = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the claim type");
            newClaim.ClaimType = Console.ReadLine();

            Console.WriteLine("Enter a claim description");
            newClaim.ClaimDesc = Console.ReadLine();

            Console.WriteLine("Amount of damage");
            newClaim.DamageAmount = Console.ReadLine();

            Console.WriteLine("Date of accident");
            newClaim.AccidentDate = Console.ReadLine();

            Console.WriteLine("Date of claim");
            newClaim.ClaimDate = Console.ReadLine();

            Console.WriteLine("Is the claim valid");
            newClaim.IsValid = Console.ReadLine();

            _claimRepo.AddClaimToQueue(newClaim);

        }
    }
}

        

        
