using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Mammal : Animal
    {
        private bool hasHair;
        public bool HasHair
        {
            get { return hasHair; }
            set { hasHair = value; }
        }

        public Mammal(double height, double weight, int age, string foodIeat, string name, bool hasHair) : base(height, weight,  age,  foodIeat,  name)
        {
            this.hasHair = hasHair;
        }

        public void Eat(string food)
        {
            if(food == FoodIEat)
            {
                Height++;
                Weight++;
            }
            else
            {
                Console.WriteLine("I can't eat this");
            }
        }

        public void GrowHair()
        {
            Weight--;
            HasHair = true;
        }

    }
}
