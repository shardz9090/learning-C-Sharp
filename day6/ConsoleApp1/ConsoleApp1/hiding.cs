using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*class A
    {
            private int x;
            protected int y;
            public int z;
    }
    class B : A
    {
        public void SetXYZ()
        {
            // x = 10;
            y = 20;
            z = 30;
        }
        public static void Main()
        {
            B b = new B();
            b.y = 20;
            b.z = 30;
            Console.WriteLine(b.y);
        }
    }*/

    /*

    class A
    {
        protected int a;
        public A(int x)
        {
            a = x;
        }
    }
    class B : A
    {
        protected int b;
        public B(int x, int y) : base(x)
        {
            b = y;
        }
    }
    class C : B
    {
        int c;
        public C(int x, int y, int z) : base(x, y)
        {
            c = z;
        }
    }
    class D
    {
        public static void Main()
        {
            Console.WriteLine("asdasdsa");
        }
    }*/
    /*    class Base
        {
            public void Display()
            {
                Console.WriteLine("Base Method ");
            }
        }
        class Derived : Base
        {
            public new void Display() { Console.WriteLine("Derived Method");  }
        }
        class HideTest
        {
            public static void Main()
            {
                Derived d = new Derived();
                d.Display();
            }
        }*/
}
