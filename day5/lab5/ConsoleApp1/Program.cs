using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace lab5
{
    /*class Rect
    {
        public int length, width;
        public void GetData(int x, int y)
        {
            length = x;
            width = y;
        }
        public int RectArea()
        {
            int area = length * width;
            return area;
        }
    }
    class RectArea
    {
        public static void Main()
        {
            int area1, area2;
            Rect rect1 = new Rect();
            Rect rect2 = new Rect();
            rect1.length = 15;
            rect1.width = 10;
            area1 = rect1.length * rect1.width;
            rect2.GetData(20, 10);
            area2 = rect2.RectArea();
            Console.WriteLine(" area 1 = " + area1);
            Console.WriteLine(" area 2 = " + area2);
        }
    }*/
    /*  class Rectangle
      {
          public int length;
          public int width;
          public Rectangle(int x, int y)
          {
              length = x;
              width  = y;
          }
          public int RectArea()
          {
              return(length * width);
          }
      }
      class RectaArea
      {
          public static void Main()
          {
              Rectangle rect1 = new Rectangle(15,10);
              int area1 = rect1.RectArea();
              Console.WriteLine("Area 1 = " + area1);
          }
      }*/
    /*class Room
    {
        public double length;
        public double width;
        public Room(double x, double y)
        {
            length = x;
            width = y;
        }
        public Room(double x)
        {
            length = width = x;
        }
        public double Area()
        {
            return (length * width);
        }
    }
    class Neww
    {
        public static void Main()
        {
            Room room1 = new Room(12.5,4.0);
            Room room2 = new Room(12.0);
            Console.WriteLine(room1.Area());
            Console.WriteLine(room2.Area());
        }
    }*/
    /*class Mathpoperation
    {   float x, y;
        public float mul(float x, float y)
        {
            this.x = x;
            this.y = y;
            return x * y;
        }
        public static float divide(float x, float y)
        {
            return x / y;
        }

    }
    class MathApplication
    {
        public static void Main()
        {
            Mathpoperation mope = new Mathpoperation();
            float a = mope.mul(4.0f, 5.0f);
        *//*    float b = mope.divide(a, 2.0f);


            float a = Mathpoperation.mul(4.0f, 5.0f);*//*
            float b = Mathpoperation.divide(a, 2.0f);
            Console.WriteLine("b = {0}", b); 

        }
    }*/

    /*class Program
    {
        static int m = 0; static int n = 0;
        static void Main(string[] args)
        {
            const int rowValues = 7;
            const int colValues = 4;
            int[,] recArr =
            {
                {0,14,16,27}, {1,2,3,4}, {4,5,6,7}, {7,8,9,10}, {12,13,14,15}, {15,16,7,18},
                {2,5,13,54 }, {9,14,54,23}
            };
            Console.WriteLine("this is and example of rectangular array ");
            for(m = 0;m < rowValues; m++)
            {
                for(n = 0; n<colValues; n++)
                {
                    Console.WriteLine("[{0}, {1} = {2}]", m, n, recArr[m,n]);
                }
            }

        }
    }*/
    /*class Program
    {
        static void Main(string[] args)
        {
            Program prg = new Program();
            prg.Display(1, 2, 3, 4);
            int[] exArr = { 23, 33, 43, 53 };
            Console.WriteLine("Example of Array");
            Console.WriteLine("New array elements added");
            prg.Display(exArr);
        }
        public void Display(params int[] val1)
        {
            foreach(int i in val1)
            {
                Console.WriteLine("The array is having : {0}",i);
            }
        }
    }*/

    /*class Program
    {
        static int m = 0; static int n = 0;
        static void Main(string[] args)
        {
            const int rowValues = 5;
            const int colValues = 5;
            int[,] recArr =
            {
                {1,0,1,0,1}, {0,1,0,1,0}, {1,0,1,0,1,}, {0,1,0,1,0}, {1,0,1,0,1,}
            };
            Console.WriteLine("this is and example of rectangular array ");
            for (m = 0; m < rowValues; m++)
            {
                for (n = 0; n < colValues; n++)
                {
                    Console.Write("{0} \t", recArr[m, n]);
                }
                Console.WriteLine();
            }

        }
    }*/
    /*class Mattrix
    {
        public static void Main()
        {
            int i,j;
            int m = 3;int n = 3;
            int[,] a = {
            {1,2,3}, 
            {4,5,6}, 
            {7,8,9}
            };
            int[,] b = {
            {1,2,3}, 
            {4,5,6}, 
            {7,8,9}
            };
            int[,] c = new int[3, 3];
            for(i=0; i < m; i++)
            {
                for(j=0; j < m; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0} ",c[i,j]);
                }
                Console.WriteLine();
            }
        }
    }*/

    /*class Prog
    {
        public void Display()
        {
            string str1 = "";
            Console.Write("enter a string ");
            str1 = Console.ReadLine();
            const char space = ' ';
            const char comma = ' ';
            char[] spacers = new char[]
            {
                space,
                comma
            };
            StringBuilder sb = new StringBuilder();
        int increment = 1;
        Console.WriteLine("The whole string is displayed below ");
            foreach(string subString in str1.Split(spacers)){
                sb.AppendFormat("{0}: word {1} is at position {0} \n" , increment++, subString);

            }
            Console.WriteLine(sb);

        }
        static void Main(string[] args)
        {
            Prog prg = new Prog();
            prg.Display();
        }
    }*/
    /*class Alphab
    {
        static int gab;
        public static void Main()
        {
            Alphab alp = new Alphab();
            alp.sortt();
            alp.search();
        }
        public void sortt()
        {
            string word = "STRING";
            *//*string wor = word.ToLower();*//*
            char[] worarr = word.ToCharArray();
            char temp;
            Console.WriteLine("Before sort = {0}", word);
            for (int i = 0; i < worarr.Length; i++)
            {
                for (int j = i + 1; j < worarr.Length; j++)
                {
                    if (worarr[i] < worarr[j])
                    {
                        temp = worarr[i];
                        worarr[i] = worarr[i + 1];
                        worarr[i + 1] = temp;
                    }
                }
            }
            Console.Write("After sort = ");
            for (int i = worarr.Length - 1; i >= 0; i--)
            {
                Console.Write(worarr[i]);
            }
            Console.WriteLine();
        }
        public void search()
        {
            string orginal = "SAHARDAUSLH";
            string org = orginal.ToLower();
            char[] worarr = org.ToCharArray();
            Console.WriteLine("Your word is {0} ", orginal);
            Console.Write("enter the letter u wanna search : ");
            string? sea = Console.ReadLine();
            string sealow = sea.ToLower();
            int count = 0;
            for (int i = 0; i < worarr.Length; i++)
            {
                if (sealow.Contains(worarr[i]+""))
                {
                    count++;
                }
            }
            Console.WriteLine("your letter {0} has been repeated {1} times", sea, count);
        }
        

        public void arrlis()
        {
            int[] ints = { 12, 23, 54, 12, 12, 23 };
            for(int i = 0;i < ints.Length;i++)
            {

            }
        }*/
/*    }*/
    /*public class outerClass
    {
        public void show()
        {
            System.Console.WriteLine("This message is from the class outerClass containing the \n nested class innerClass.\n");
        }
        public innerClass abc()
        {
            return new innerClass();
        }
        public class innerClass
        {
            public void display()
            {
                Console.WriteLine("this is a nested class example in c#. \n This info is in the innermost class innerClass");

            }
        }
    }
    public class nestedClass
    {
        public static void Main()
        {
            outerClass obj2 = new outerClass();
            obj2.show();
            Console.WriteLine(obj2.GetType());
            outerClass.innerClass obj1 = new outerClass.innerClass();
            Console.WriteLine( obj2.abc().GetType());
            
            obj1.display();

        }
    }*/

    class Number
    {
        private int number;
        public int Anumber
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        public static void Main()
        {
            Number n = new Number();
            n.Anumber= 100;
            int m = n.Anumber;
            Console.WriteLine("Number = {0}", m);

        }
    }
    /*class Proptest
    {
        
    }*/


    }