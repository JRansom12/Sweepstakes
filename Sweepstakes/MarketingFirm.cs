using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm : IUserInterface
    {
        // member variables
        ISweepstakesManager sweepstakesManager;

        // constructor
        public MarketingFirm(ISweepstakesManager sweepstakesManager)
        {
            this.sweepstakesManager = sweepstakesManager;
        }

        // member methods

        public void RunSweepstakes()
        {
            Sweepstakes sweepstakeName = new Sweepstakes();
            sweepstakeName.SweepstakesMethod();
            sweepstakesManager.InsertSweepstakes(sweepstakeName);
            string answer = GetUserInput("Would you like to run another sweepstake? Enter 'yes' or 'no'");
            switch (answer)
            {
                case "yes":
                    RunSweepstakes();
                    break;
                case "no":
                    break;
                default:
                    break;
            }
        }
        public string GetUserInput(string text)
        {
            Console.WriteLine(text);
            string response = Console.ReadLine().ToString();
            return response;
        }
    }
}
