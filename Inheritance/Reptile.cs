using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile: Animal
    {
        public string BloodType { get; set; }
        public bool CanShedSkin { get; set; }
        public bool CanChangeColors { get; set; }
        public bool LikesWarmWeather { get; set; }

        public void PrintReptile()
        {
            Console.WriteLine($"Hi, my name is lizard. I have {Legs} legs and I am {BloodType}.");
        }
    }
}

