// See https://aka.ms/new-console-template for more information
using System;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Scope
{
    /*int x = 10;
    static int y = 20;
    */
    
    public static void Main()
    {   /*
        Console.WriteLine("please enter your name");
        string? UserName = Console.ReadLine();
        string? UserName1 = Console.ReadLine();

        Console.WriteLine("hello" + UserName + "\r" + UserName1);
        Console.WriteLine("Hello {0} {1}", UserName, UserName1);
        */
        /*
        double x = 5.0;
        double y;
        y = Math.Sqrt(x);
        double z = Math.Round(y, 2);
        Console.WriteLine("y = " + z);
        */
        /*
        Console.WriteLine("Integral Literal                             : {0}", 58);
        Console.WriteLine("Double literal                               : {0}", 1.6180339887498);
        Console.WriteLine("Decimal Literal                              : {0}", 1.6180339887498m);
        Console.WriteLine("Exponential notation for Decimal Literal     : {0}", 6.023E23f);
        Console.WriteLine("Hexadecimal literal                          : {0}", 0x003A);
        */

        /*
                Scope s = new Scope();
                int x = 100;
                int y = 200;

                Console.WriteLine(x); //local x
                Console.WriteLine(y); //local y
                // Console.WriteLine(this.x); //instance x
                s.Display();
                Console.WriteLine(Scope.y); //static y
                }
                public void Display()
                {
                    Console.WriteLine(this.x);
                }
        */
        // implicit conversion
        /* byte x1 = 75;
         short x2 = x1;
         int x3 = x2;
         long x4 = x3;
         float x5 = x4;
         decimal x6 = x4;
         Console.WriteLine(x6);*/

        /*int m = 50;
        byte n = (byte)m;
        long x = 1234L;
        int y = (int)x;
        float f = 50.0F;
        long z= (long)f;
        Console.WriteLine(m);
        Console.WriteLine(y);
        Console.WriteLine(x);
        Console.WriteLine(f);
        Console.WriteLine(n);*/

        /* double x = 65.40;
         double y = 79.60;
         x = (int)(x + 0.5); y = (int)(y+0.5);
         Console.WriteLine(x);
         Console.WriteLine(y);
         int m = 100;
         string s = m.ToString();
         Console.WriteLine(s);
         Console.WriteLine(s.GetType());
         string r = "100";
         int n = int.Parse(r);
         int z = n + 50;
         Console.WriteLine(z);
         Console.WriteLine(z.GetType());*/

      /*  float sum;
        int i;
        sum = 0.0F;
        for(i=1; i<10; i++) 
        {
            sum = sum + 1 / (float)i;
            Console.Write("i = " + i);
            Console.WriteLine(" Sum = "+sum);
        }*/

        
    }
}
