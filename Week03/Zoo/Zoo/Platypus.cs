using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Platypus : Mammal, IWalk
    {
        public Platypus(double height, double weight, int age, string foodIeat, string name, bool hasHair) : base(height, weight, age, foodIeat, name, hasHair)
        {

        }

        public void Walk()
        {
            Console.WriteLine("Platypus walking sounds");
        }

        public int WalkSpeed()
        {
            return 100 - (int)Weight;
        }
    }
}
