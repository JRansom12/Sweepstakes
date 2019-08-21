using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        //member variables
        private Stack<Sweepstakes> sweepstakesStack;

        // constructor
        public SweepstakesStackManager()
        {
            sweepstakesStack = new Stack<Sweepstakes>();
        }
        public Sweepstakes GetSweepstakes(Stack<Sweepstakes> sweepstakesStack) //pop off of stack
        {
            Sweepstakes topOfStack = sweepstakesStack.Pop();
            return topOfStack;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)  //push onto stack
        {
            sweepstakesStack.Push(sweepstakes);
        }
        
    }
}
