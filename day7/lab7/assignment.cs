using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Shape
    {
        public double x;
        public double y;
        public Shape(double a, double b)
        {
            this.x = a; this.y = b;
        }
        public virtual void Area()
        {
            Console.WriteLine("Area = {0} ", x+y);
        }
    }
    class Triangle : Shape
    {
        public Triangle(double a, double b): base(a, b) { }
        public override void Area()
        {
            Console.WriteLine("Area of triangle = {0} ", x * y / 2);
        }

    }
    class Rectangle : Shape
    {
        public Rectangle(double a, double b) : base(a, b) { }
        public override void Area()
        {
            Console.WriteLine("Area of Rectangle = {0} ", this.x * this.y);
        }
    }

    class Program
    {
        public static void Main()
        {
            Shape s1 = new Shape(10, 10);
            s1.Area();

            Shape s2 = new Triangle(20,20);
            Shape s3 = new Rectangle(30, 30);
            s2.Area();
            s3.Area();
        }
    }
}
