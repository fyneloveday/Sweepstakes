﻿using System;
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
        int registrationNumber;

        public int getRegistrationNumber(int min, int max)
        {
            Random number = new Random();
            return  number.Next(1, 100);
        }

        public void GetInfo()
        {
            firstName = Console.ReadLine();
            lastName = Console.ReadLine();
            emailAddress = Console.ReadLine();
            registrationNumber = Console.ReadLine();

        }
    }
}