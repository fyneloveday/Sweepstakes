using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        Dictionary<int, Contestants> contestants = new Dictionary<int, Contestants>();
        public Sweepstakes()
        {
            string name;
        }
        public void RegisterContestant()
        {
            Contestants contestant = new Contestants();
            contestant.GetInfo();
           // contestant.registrationNumber = 
            contestants.Add(contestant.registrationNumber, contestant);
        }


        public string PickWinner()
        {
            //get random number --> get random registration number

            //string value = Console.ReadLine();

            //foreach (KeyValuePair<string, string> winner in winningContestant)
            //{
            //    if (contestant.Value == value)
            //        Console.WriteLine("Month " + month.Key + " is of season " + month.Value);
            //}
            return "";
        }

        public void PrintContestantInfo(Contestants contestant)
        {
            Contestants contestant = new Contestant();
            Console.WriteLine(contestant Info)
        }
       
    }
}