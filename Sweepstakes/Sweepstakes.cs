using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes : IUserInterface
    {
        //member variables
        private int min; //minimum number of contestants
        private int numberOfContestants;
        private Contestant contestant;
        private List<Contestant> contestants;
        private bool match;


        //constructor
        public Sweepstakes()
        {
            min = 0;
            numberOfContestants = 0;
            contestant = new Contestant();
            contestants = new List<Contestant>();
        }


        // member methods
        private void SweepstakesMethod(string name)
        {

        }
        private void GetUserInput()
        {
            contestant = new Contestant();
            Console.WriteLine("Enter first name");
            contestant.firstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            contestant.lastName = Console.ReadLine();
            Console.WriteLine("Enter email address");
            contestant.emailAddress = Console.ReadLine();
        }
        private void RegisterContestant(Contestant contestant)
        {
            contestant.registrationNumber = numberOfContestants;
            numberOfContestants++;
        }
        private Contestant PickWinner(List<Contestant> contestants) //return string or Contestant?
        {
            int winner = GenerateRandomNumber(min, numberOfContestants);
            while (match == false)
            for (int i = 0; i < contestants.Count; i++) //search through dictionary for winner
            {
                if(winner == contestant.registrationNumber)
                {
                    match = true;
                    return contestant;
                }                            
            }
        }
        private int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();
            int number = random.Next(min, max);
            return number;
        }
        private void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("First name: " + contestant.firstName + "\nLast name: " + contestant.lastName + "\nEmail address: " + contestant.emailAddress + "\nRegistration number: " + contestant.registrationNumber);
        }
        private void CreateDictionary()
        {
            Dictionary<string, int> contestantsInSweepstakes = new Dictionary<string, int>();
            foreach (Contestant contestant in contestants)
            {
                contestantsInSweepstakes.Add(contestant.firstName + " " + contestant.lastName, contestant.registrationNumber);
            }
        }
    }
}
