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

        public Sweepstakes GetSweepstakes() //pop off of stack
        {
            throw new NotImplementedException();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)  //push onto stack
        {
            
        }

        private void CreateContestantStack()
        {
            throw new NotImplementedException();
            //for (int i = 0; i < sweepstakes.contestants.Count; i++)
            //{
            //    contestantStack.Push(sweepstakes.contestants[i]);
            //}
        }
    }
}
