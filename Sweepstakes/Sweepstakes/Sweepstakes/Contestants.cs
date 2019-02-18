using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweepstakes
{
    public class Contestants
    {

        string firstName;
        string lastName;
        string emailAddress;
        public int registrationNumber;

        public void GetInfo()
        {
            firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string emailAddress = Console.ReadLine();
        }
    }
}