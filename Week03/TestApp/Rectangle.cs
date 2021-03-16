using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Rectangle
    {
        private int width;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        private int height;
        public int Height
        { 
            get { return height; }
            set { height = value; }
        }


        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public virtual int GetArea()
        {
            return height * width;
        }

        public virtual int GetPerimeter()
        {
            return (height + width) * 2;
        }

        public override string ToString()
        {
            return "I am a rectangle";
        }
    }
}
