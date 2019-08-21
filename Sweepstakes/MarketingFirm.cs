using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        // member variables


        // constructor
        public MarketingFirm()
        {
            Sweepstakes primeRib = new Sweepstakes();
            Sweepstakes fordRanger = new Sweepstakes();
            Sweepstakes tokyoMarathon = new Sweepstakes();
            Sweepstakes treeFiddy = new Sweepstakes();

        }

        // member methods
        public void ChooseManager()
        {
            Console.WriteLine("Please choose a stack or queue sweepstakes manager. Enter 'stack or 'queue'");
            string manager = Console.ReadLine();
            switch (manager)
            {
                case "stack":

                    break;
                case "queue":

                    break;
                default:
                    ChooseManager();
                    break;
            }
        }
    }
}
