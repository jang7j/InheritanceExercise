using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public double WingSpan { get; set; } = 100.00;
        public bool LaysEggs { get; set; }
        public bool CanFly { get; set; } 
        public bool CanSwim { get; set; }
    public void PrintBird()
    {
        Console.WriteLine($"This bird can fly: {CanFly}");
    }
    }


    

}
