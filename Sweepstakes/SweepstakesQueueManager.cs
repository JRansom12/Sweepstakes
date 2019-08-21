using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        // member variables
        private Queue<Sweepstakes> sweepstakesQueue;

        // constructor
        public SweepstakesQueueManager()
        {
            sweepstakesQueue = new Queue<Sweepstakes>();
        }

        // member methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesQueue.Enqueue(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes startOfQueue = sweepstakesQueue.Dequeue();
            return startOfQueue;
        }
    }
}
