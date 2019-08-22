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
        private string nameOfSweepstake;
        private Contestant contestant;
        //private List<Contestant> contestants;
        Dictionary<int, Contestant> contestantsInSweepstakes;

        //constructor
        public Sweepstakes()
        {
            nameOfSweepstake = null;
            min = 0;
            numberOfContestants = 0;
            //contestants = new List<Contestant>(); // To run sweepstakes with a list
            contestantsInSweepstakes = new Dictionary<int, Contestant>();
        }

        // member methods
        public void SweepstakesMethod() //parameter string name
        {
            nameOfSweepstake = GetUserInput("What is the name of this sweepstake?");
            Console.WriteLine("How many contestants would you like to enter?");
            totalNumberOfContestants = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < totalNumberOfContestants; i++)
            {
                contestant = new Contestant();
                RegisterContestant(contestant);
            }
            string winner = PickWinner(contestantsInSweepstakes);
            Console.WriteLine("The winner of " + nameOfSweepstake + " is " + winner);
        }
        public string GetUserInput(string text)
        {
            Console.WriteLine(text);
            string response = Console.ReadLine();
            return response;
        }
        private void RegisterContestant(Contestant contestant)
        {
            contestant.firstName = GetUserInput("Enter first name:");
            contestant.lastName = GetUserInput("Enter last name:");
            contestant.emailAddress = GetUserInput("Enter email address:");
            contestant.registrationNumber = numberOfContestants;
            numberOfContestants++;
            contestantsInSweepstakes.Add(contestant.registrationNumber, contestant);
            //contestants.Add(contestant);
        }
        private string PickWinner(/*List<Contestant> contestants*/Dictionary<int, Contestant> contestantsInSweepstakes)
        {
            int winningNumber = GenerateRandomNumber(min, numberOfContestants);
            //Contestant winner = contestants.Find(i => i.registrationNumber == winningNumber);
            int winKey = contestantsInSweepstakes.Keys.FirstOrDefault(x => x.Equals(winningNumber));
            Contestant winner = contestantsInSweepstakes[winKey];
            return winner.firstName + " " + winner.lastName;
            //return winner; option to return Contestant instead of string
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
