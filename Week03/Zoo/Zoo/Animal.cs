using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Animal
    {
        private double weight;
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        private string foodIEat;
        public string FoodIEat
        { 
            get
            {
                return foodIEat;
            }
            set
            {
                foodIEat = value;
            }
        }

        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        private double height;
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Animal(double height, double weight, int age, string foodIeat, string name)
        {
            this.height = height;
            this.weight = weight;
            this.age = age;
            this.foodIEat = foodIeat;
            this.name = name;
        }

        public string Speak()
        {
            return "????";
        }

        public override string ToString()
        {
            return name;
        }
    }
}
