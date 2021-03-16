using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Square : Rectangle
    {
        public Square(int length) : base (length, length)
        {
        }

        public override int GetPerimeter()
        {
            return Width * 4;
        }

        public override int GetArea()
        {
            return Width * Width;
        }

        public override string ToString()
        {
            return "I am a square";
        }

    }
}
