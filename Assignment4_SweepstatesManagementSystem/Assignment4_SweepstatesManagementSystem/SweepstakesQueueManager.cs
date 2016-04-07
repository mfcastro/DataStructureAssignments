using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_SweepstatesManagementSystem
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        public Queue<Sweepstakes> sweepStakesQueue = new Queue<Sweepstakes>();

        public Sweepstakes GetNextSweepstakesWinner()
        {
            return sweepStakesQueue.Peek();
            
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepStakesQueue.Enqueue(sweepstakes);
        }
    }
}
