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
        Dictionary<int, Contestant> contestantsInSweepstakes;

        //constructor
        public Sweepstakes()
        {
            min = 0;
            numberOfContestants = 0;
            contestants = new List<Contestant>();
            contestantsInSweepstakes = new Dictionary<int, Contestant>();
        }


        // member methods
        public void SweepstakesMethod() //parameter string name
        {
            totalNumberOfContestants = Convert.ToInt32(GetUserInput("How many contestants would you like to enter?"));
            for (int i = 0; i < totalNumberOfContestants; i++)
            {
                contestant = new Contestant();
                RegisterContestant(contestant);
                contestantsInSweepstakes.Add(contestant.registrationNumber, contestant);
                //contestants.Add(contestant);
                //RegisterContestant(contestant);
            }
            Console.WriteLine(PickWinner(contestantsInSweepstakes));
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
        private string PickWinner(/*List<Contestant> contestants*/Dictionary<int, Contestant> contestantsInSweepstakes)
        {
            int winningNumber = GenerateRandomNumber(min, numberOfContestants);
            //Contestant winner = contestants.Find(i => i.registrationNumber == winningNumber);
            int winKey = contestantsInSweepstakes.Keys.FirstOrDefault(x => x.Equals(winningNumber));
            Contestant winner = contestantsInSweepstakes[winKey];
            return "The winner is " + winner.firstName + " " + winner.lastName;
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
    }
}
