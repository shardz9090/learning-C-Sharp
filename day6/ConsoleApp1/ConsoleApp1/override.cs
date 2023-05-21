using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// virtual method can only be override by child class using override function
/*namespace ConsoleApp1
{
    class Super
    {
        protected int x;
        public Super(int x)
        {
            this.x = x;
        }
        public virtual void Display()
        {
            Console.WriteLine("super x = " + x);
        }
    }
    class Sub : Super
    {
        int y;
        public Sub(int x, int y) : base(x)
        {
            this.y = y;
        }
        public override void Display()
        {
            Console.WriteLine("super x = " + x);
            Console.WriteLine("Sub y = " + y);
        }
    }
    class OverrideTest
    {
        public static void Main()
        {
            Sub s1 = new Sub(100, 200);
            s1.Display();
        }
    }
}
*/