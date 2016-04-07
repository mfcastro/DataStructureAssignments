using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_SweepstatesManagementSystem
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        public Stack<Sweepstakes> sweepStakesStack = new Stack<Sweepstakes>();

        public Sweepstakes GetNextSweepstakesWinner()
        {
            return sweepStakesStack.Pop();

        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepStakesStack.Push(sweepstakes);
        }
    }
}
