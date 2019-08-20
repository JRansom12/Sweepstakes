using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Contestant> contestantStack = new Stack<Contestant>();
        private void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            throw new NotImplementedException();
        }
        private Sweepstakes GetSweepstakes()
        {
            throw new NotImplementedException();
        }
        private void CreateContestantStack()
        {
            for (int i = 0; i < sweepstakes.contestants.Count; i++)
            {
                contestantStack.Push(sweepstakes.contestants[i]);
            }
        }
    }
}
