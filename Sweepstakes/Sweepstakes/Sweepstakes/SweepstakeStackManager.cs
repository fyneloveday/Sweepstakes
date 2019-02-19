using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweepstakes
{
    public class SweepstakeStackManager : ISweepstakesManager
    {
        public Sweepstakes GetSweepstakes()
        {
            Contestants stack = new Contestants();
            static Stack<int> GetPrizes()
            {
                Stack<int> sweepstakes = new Stack<int>();
                sweepstakes.Push(100);
                sweepstakes.Push(1000);
                sweepstakes.Push(10000);
                return sweepstakes;
            }
        }

        //public void InsertSweepstakes(Sweepstakes sweepstakes)
        //{
        //    throw new NotImplementedException();
        //}
    }
}