using System;
namespace ConsoleApp1
{
    /*struct Rectangle
    {
        int a, b;
        public Rectangle(int x, int y)
        {
            a=x; b=y;
        }
        public int Area()
        {
            return (a*b);
        }
        public void Display()
        {

            Console.WriteLine("Area = " + Area());
        }

    }
    class TestRectangle
    {
        public static void Main()
        {
            Rectangle rect = new Rectangle(10, 20);
            rect.Display();
        }
    }*/
    class Area
    {
        public enum Shape
        {
            Circle,
            Square
        }
        public void AreaShape(int x, Shape shape)
        {
            double area;
            switch (shape)
            {
                case Shape.Circle:
                    area = Math.PI * x * x;
                    Console.WriteLine("Circle Area = " + area);
                    break;
                case Shape.Square:
                    area = x * x;
                    Console.WriteLine("Squared Area = " + area);
                    break;
                default:
                    Console.WriteLine("invalid input"); break;
            }
        }
    }
    class EnumTest
    {
        public static void Main()
        {
            Area area = new Area();
            area.AreaShape(15, Area.Shape.Circle);
            area.AreaShape(15, Area.Shape.Square);
            area.AreaShape(15, (Area.Shape)1);
            area.AreaShape(15, (Area.Shape)0);
        }
    }
}