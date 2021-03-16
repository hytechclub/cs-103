using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Console.WriteLine("Enter Height of a Rectangle");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter Width of a Rectangle");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Rectangle rectangle = new Rectangle(width, height);
            Console.WriteLine("The Area is:");
            Console.WriteLine(rectangle.GetArea());
            Console.WriteLine("The Perimeter is:");
            Console.WriteLine(rectangle.GetPerimeter());

            Console.WriteLine("Enter length of one side of a Square");
            int length = Convert.ToInt32(Console.ReadLine());
            Square square = new Square(length);
            Console.WriteLine("The Area is: ");
            Console.WriteLine(square.GetArea());

            List<Rectangle> listOfRectangles = new List<Rectangle>();
            listOfRectangles.Add(rectangle);
            listOfRectangles.Add(square);

            foreach(Rectangle r in listOfRectangles)
            {
                Console.WriteLine(r.ToString());
            }


            Console.ReadLine();
        }
    }
}
