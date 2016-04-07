using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_SweepstatesManagementSystem
{
    class Sweepstakes
    {
        Random rand = new Random();
        public string sweepStakesName;
        int numberOfContestants;

       public Dictionary<int, Contestant> sweepStakesContestants = new Dictionary<int, Contestant>();
      
        public Sweepstakes(string name)
        {
            this.sweepStakesName = name;
        }

        public void RegisterContestant(Contestant contestant)
        {
            numberOfContestants++;
            sweepStakesContestants.Add(numberOfContestants, contestant);
            contestant.contstantNumber = numberOfContestants;
        }

        public string PickWinner()
        {


            int randomContestant = rand.Next(1 , numberOfContestants+1);
            Contestant contestantName = sweepStakesContestants[randomContestant];

            string winnerName = contestantName.name;

            return winnerName;

        }

        public void PrintContestantInfo(Contestant contestant)
        {

            Console.WriteLine("Contestant: {0}", contestant.name);
            Console.WriteLine("Contestant Number: {0}", contestant.contstantNumber);
            Console.WriteLine("Conestant's Eamil:  {0}", contestant.email);
        }

    }
}
