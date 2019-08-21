using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Factory
    {
        public ISweepstakesManager ChooseManager()
        {
            ISweepstakesManager manager = null;
            Console.WriteLine("Please choose a stack or queue sweepstakes manager. Enter 'stack or 'queue'");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "stack":
                    manager = new SweepstakesStackManager();
                    return manager;
                case "queue":
                    manager = new SweepstakesQueueManager();
                    return manager;
                default:
                    ChooseManager();
                    break;
            }
            return manager;
        }
    }
}
