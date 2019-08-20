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


        //constructor
        public Sweepstakes()
        {
            min = 0;
            numberOfContestants = 0;
            contestant = new Contestant();
        }


        // member methods
        private void SweepstakesMethod(string name)
        {

        }
        private void RegisterContestant(Contestant contestant)
        {
            
        }
        private void /*string*/ PickWinner()
        {

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
