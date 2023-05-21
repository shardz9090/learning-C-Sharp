/*using System;
using System.Data.SqlTypes;

namespace multi
{
    *//*interface Addition
    {
        int Add();
    }
    interface Multiplication
    {
        int Mul();
    }
    class Computation : Addition, Multiplication
    {
        int x, y;
        public Computation(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int Add()
        {
            return x + y;
        }
        public int Mul()
        {
            return x * y;
        }
    }
    class InterfaceTest1
    {
        public static void Main()
        {
            Computation com = new Computation(10, 20);
            Addition add = (Addition)com;
            Console.WriteLine("Sum = " + add.Add());
            Multiplication mul = (Multiplication)com;
            Console.WriteLine("product = "+mul.Mul());
        }
    }*//*

    interface Area
    {
        double Compute(double x);
    }
    class Square : Area
    {
        public double Compute(double x)
        {
            return x * x;
        }
    }
    class Circle : Area
    {
        public double Compute(double x)
        {
            return(Math.PI * x * x);
        }
    }
    class InteraceTest2
    {
        public static void Main()
        {
            Square sqr = new Square();
            Circle cir = new Circle();
            Area area;
            area = sqr as Area;
            Console.WriteLine("Area of square =" + area.Compute(10.0));
            area = cir as Area;
            Console.WriteLine("Area of circle =" + area.Compute(10.0));
        }
    }
}


*/