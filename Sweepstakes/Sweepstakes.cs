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
        private int totalNumberOfContestants;
        private Contestant contestant;
        private List<Contestant> contestants;

        //constructor
        public Sweepstakes()
        {
            min = 0;
            numberOfContestants = 0;
            totalNumberOfContestants = 5;
            contestants = new List<Contestant>();
        }


        // member methods
        public void SweepstakesMethod() //parameter string name
        {
            Dictionary<string, int> contestantsInSweepstakes = new Dictionary<string, int>();
            for (int i = 0; i < totalNumberOfContestants; i++)
            {
                contestant = new Contestant();
                contestants.Add(contestant);
                RegisterContestant(contestant);
            }
            Console.WriteLine(PickWinner(contestants));
        }
        public string GetUserInput(string text)
        {
            Console.WriteLine(text);
            string response = Console.ReadLine().ToString();
            return response;
        }
        private void RegisterContestant(Contestant contestant)
        {
            contestant.firstName = GetUserInput("Enter first name:");
            contestant.lastName = GetUserInput("Enter last name:");
            contestant.emailAddress = GetUserInput("Enter email address:");
            contestant.registrationNumber = numberOfContestants;
            numberOfContestants++;
        }
        private string PickWinner(List<Contestant> contestants)
        {
            int winningNumber = GenerateRandomNumber(min, numberOfContestants); //search through dictionary for winner
            Contestant winner = contestants.Find(i => i.registrationNumber == winningNumber);
            return winner.firstName + " " + winner.lastName;
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
            foreach (KeyValuePair<string, int> contestant in contestantsInSweepstakes)
            {
                Console.WriteLine(contestant.Key + " - " + contestant.Value);
            }
        }
    }
}
