using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweepstakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        public Sweepstakes GetSweepstakes()
        {

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("Elements in queue: ");
            foreach (int number in queue)
            {
                Console.WriteLine(number);
            }

            int startOfQueue = queue.Dequeue();

            queue.Enqueue(92);

            Console.WriteLine("Elements in queue after Dequeue and Enqueue(92): ");
            foreach (int number in queue)
            {
                Console.WriteLine(number);
            }
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            throw new NotImplementedException();
        }
    }
}