using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_SweepstatesManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Contestant marco = new Contestant("Marco", "Mfcastro50@gmail.com");
            Contestant emily = new Contestant("Emily", "Ekyoung811@gmail.com");
            Contestant kristy = new Contestant("Kristy", "LkCastro50@gmail.com");

            Contestant andy = new Contestant("Andy", "ADomoto@gmail.com");
            Contestant cindy = new Contestant("Cindy", "CYoung@gmail.com");
            Contestant alex = new Contestant("Alex", "AYoung@gmail.com");

            Contestant conner = new Contestant("Conner", "Conner@gmail.com");
            Contestant bob = new Contestant("Bob", "Bob@gmail.com");
            Contestant sara = new Contestant("Sara", "Sara@gmail.com");


            Sweepstakes sweepStakes1 = new Sweepstakes("Win Tickets");
            Sweepstakes sweepStakes2 = new Sweepstakes("Movie tickets");
            Sweepstakes sweepStakes3 = new Sweepstakes("Basketball ticket");

            sweepStakes1.RegisterContestant(marco);
            sweepStakes1.RegisterContestant(emily);
            sweepStakes1.RegisterContestant(kristy);

            sweepStakes2.RegisterContestant(andy);
            sweepStakes2.RegisterContestant(cindy);
            sweepStakes2.RegisterContestant(alex);

            sweepStakes3.RegisterContestant(conner);
            sweepStakes3.RegisterContestant(bob);
            sweepStakes3.RegisterContestant(sara);


            SweepstakesStackManager sweepStakesStack = new SweepstakesStackManager();
            sweepStakesStack.InsertSweepstakes(sweepStakes1);
            sweepStakesStack.InsertSweepstakes(sweepStakes2);
            sweepStakesStack.InsertSweepstakes(sweepStakes3);


            SweepstakesQueueManager sweepStakesQueue = new SweepstakesQueueManager();
            sweepStakesQueue.InsertSweepstakes(sweepStakes1);
            sweepStakesQueue.InsertSweepstakes(sweepStakes2);
            sweepStakesQueue.InsertSweepstakes(sweepStakes3);


            foreach(Sweepstakes sweepStakes in sweepStakesQueue.sweepStakesQueue)
            {
                foreach(KeyValuePair<int, Contestant> person in sweepStakes.sweepStakesContestants)
                {
                    sweepStakes.PrintContestantInfo(person.Value);
                    Console.WriteLine();
                    Console.WriteLine("__________________________");
                }
            }


            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("DRAW {0}", i+1);

                Console.WriteLine("Stack");

                    foreach (Sweepstakes sweepStakes in sweepStakesStack.sweepStakesStack)
                    {
                        string winner = sweepStakes.PickWinner();

                        Console.WriteLine("{0} winner is {1}", sweepStakes.sweepStakesName, winner);

                }
               

                Console.WriteLine("___________________________");

                Console.WriteLine("Queue");

                foreach (Sweepstakes sweepStakes in sweepStakesQueue.sweepStakesQueue)
                {
                    string winner = sweepStakes.PickWinner();

                    Console.WriteLine("{0} winner is {1}", sweepStakes.sweepStakesName, winner);

                }

                Console.WriteLine("-----------------------------");
            }



            Console.ReadLine();


        }
    }
}
