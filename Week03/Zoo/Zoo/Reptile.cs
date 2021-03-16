using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Reptile : Animal
    {
        private int eggs;
        public int Eggs
        {
            get { return eggs; }
            set { eggs = value; }
        }

        public Reptile(double height, double weight, int age, string foodIeat, string name, int eggs) : base(height, weight, age,  foodIeat, name)
        {
            this.eggs = eggs;
        }

        public string LayEggs()
        {
            return Name + " lays " + eggs + " eggs.";
        }
    }
}
