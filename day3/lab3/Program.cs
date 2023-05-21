
using System;
using System.Collections;
using System.Globalization;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
/*************Program 1**********/


namespace lab3
{
    /*class Shardul
    {
        public static void Main()
        {
            Shardul S1 = new Shardul() ;
            int m = 5;
            for (; m != 100;)
            {
                System.Console.WriteLine(m);
                m += 5;
            }
            S1.Hello();
            Foreachn();
            Shardul.Gotolabel();
            Shardul.MyName();

        }
        public void Hello()
        {
            int num1=0, num2  = 10;
            for(; ((num1 <=10)&&(num2>=0)); num2--, num1++)
            {
                System.Console.WriteLine("First number {0} is {1} than Second Number {2}. \t", num1, (num1>num2?'>':'<'), num2);

            }
        }
        public static void Foreachn()
        {
            int[] arrayInt = { 11, 22, 33, 44 };
            foreach(int m in arrayInt)
            {
                Console.Write(" " + m);
            }
            Console.WriteLine();
        }
        public static void Gotolabel()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(" ");
                if (i >= 10)
                    break;
                for (int j = 1; j < 100; j++)
                {
                    Console.Write(" * ");
                    if (j == i)
                        goto loop1;
                }
            loop1: continue;

            }
            Console.WriteLine("termination by break");
        }
        public static void MyName()
        {

            Console.WriteLine("  SSS        M          M  ");
            Console.WriteLine(" S    S      M M      M M  ");
            Console.WriteLine("SS           M   M  M   M  ");
            Console.WriteLine(" SSSS        M    M     M  ");
            Console.WriteLine("      SS     M          M  ");
            Console.WriteLine("S    S       M          M  ");
            Console.WriteLine("  SSS        M          M  ");

        }

    }



    *//*********************PROGRAM 2**********************//*

    class Method
    {
        public int Cube (int x)
        {
            return x*x*x;

        }
    }
    class MethodTest
    {
        public static void Main()
        {
            Method M = new Method();
            int y = M.Cube(5);
            Console.WriteLine(y);
        }
    }



    *//***********************PROGRAM 3****************************//*

    class PassByValue
    {
        static void Change(int m)
        {
            m = m + 10;
        }
        public static void Main()
        {
            int x = 100;
            Change(x);
            Console.WriteLine("x={0}", x);
        }
    }



    class PassByRef
    {
        static void Swap(ref int x, ref int y)
        {
            int temp = x; x = y; y = temp;
        }
        public static void Main()
        {
            int m = 100;
            int n = 200;
            Console.WriteLine("Before Swapping");
            Console.WriteLine("m = {0}", m);
            Console.WriteLine("n = {0}", n);
            Swap(ref m, ref n);
            Console.WriteLine("After Swapping");
            Console.WriteLine("m = {0}", m);
            Console.WriteLine("n = {0}", n);
        }
    }



    class Params
    {
        static void Parray(params int[] arr)
        {
            Console.Write("Array Elements  are:");
            foreach(int i in arr)
            {
                Console.Write(" "+i);
            }
            Console.WriteLine();

        }
        public static void Main()
        {
            int[] x= { 11, 22, 33 };
            Parray(x);
            Parray();
            Parray(100,200);

        }
    }



    class Output
    {
        static void Square(int x, out int y)
        {
            y = x * x;
        }
        public static void Main()
        {
            int m;
            Square(10, out m);
            Console.WriteLine("m= {0}", m);
        }
    }

    class TerneryExample
    {
    static void Main()
    {
    int num = 3;
    string result = (num > 2) ? "True" : "False";
    Console.WriteLine(result);
    }
    }
    class Record
    {
        static void Main()
        {
            Console.WriteLine("name ");
            string? name = Console.ReadLine();
            Console.WriteLine("Grade ");
            string grade = Console.ReadLine().ToLower();
            if (grade == "a")
            {
                Console.WriteLine("{0} is an outstanding student", name);
                Console.WriteLine("you have a scholarship");
            }
            else if (grade == "b")
                Console.WriteLine("{0} is a good student", name);

            else if (grade == "c")
                Console.WriteLine("{0} is an avg student", name);
            else if (grade == "d")
                Console.WriteLine("{0} needs more practice student", name);
            else
                Console.WriteLine("{0} needs lot of practice student", name);

        }
    }*/

    /*class Odds{
        public static void Main()
        {

            int i = 0;
            int x = 0;
            int e = 0;
        Odds:
            if (i%2 != 0)
            {
                x += i;

            }
        Even:
            if (i%2 == 0)
            {
                e += i;
            }
            i++;

        if (i <= 20)
            goto Odds;
        else if(i>20)
            goto printi;
        else
            goto Even;
        printi:
            Console.WriteLine("Even sum = {0}", x);
            Console.WriteLine("Odd sum = {0}", e);
        }
    *//*}*//*

    */
    /*class Program
    {
        public static void Main()
        {   int n = 1;
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(n + " ");
                        n++;
                    }
                    Console.WriteLine();
                }
        }
    }*/

    /*class Conditions
    {
        public static void Main()
        {
            Console.Write("Enter a number ");
            int num = Convert.ToInt32(Console.ReadLine());
            int y = (num > 0) ? 1 : (num == 0) ? 0 : -1;
            Console.WriteLine(y);
        }
    }*/

    /*class Compute
    {
        public static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0, x;
            while (num != 0)
            {
                x = num % 10;
                sum += x;
                num /= 10;
            }
            Console.WriteLine(sum);
        }
    }*/

    /*class Assi
    {
        public static void Main()
        {
            Assi ai = new Assi();
            ai.repea();
            ai.dollar();
            pyramid();

        }
        public void repea()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();
            }
        }
        public void dollar()
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();
            }
        }
        public static void pyramid()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5 - i; j > 0; j--)
                {
                    Console.Write("   ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("{0}      ", i);
                }
                Console.WriteLine();
            }
        }
    }*/


    /*class Arra
    {
        public static void Main()
        {
            int[] number = new int[9];
            for(int i = 0; i < number.Length;i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
        }
    }*/

    /*class Arraa
    {
        static int rows = 20;
        static int columns = 20;
        public static void Main()
        {
            int[,] product = new int[rows, columns];
            Console.WriteLine("Multiplication table");
            Console.WriteLine(" ");
            int i,j;
            for(i = 10; i<rows; i++)
            {
                for(j = 10; j < columns; j++)
                {
                    product[i,j] = i*j;
                    Console.Write(" "+ product[i,j]);
                }
                Console.WriteLine(" ");
            }
        }

    }*/

    /*class Nearra
    {
        public static void Main()
        {
            ArrayList n = new ArrayList();
            n.Add("A");
            n.Add("C");
            n.Add("B");
            n.Add("D");
            n.Add("E");
            n.Add("6");
            Console.WriteLine("Capacity = "+ n.Capacity);
            Console.WriteLine("Elements present = " + n.Count);
            try {
                n.Sort();
            }
            catch (Exception e){
                Console.WriteLine(e);
            }        
            for (int i = 0; i<n.Count; i++)
            {
                Console.WriteLine(n[i]);
            }
            Console.WriteLine();
            n.RemoveAt(4);
            for(int i = 0; i<n.Count; i++)
            {
                Console.WriteLine(n[i]);
            }
        }
    }*/

    /*public class Stringstr
    {
        public static void Main(string[] args)
        {
            string s1 = "Lean";
            string s2 = s1.Insert(3, "r");
            string s3 = s2.Insert(5, "er");
            for (int i = 0; i < s3.Length; i++)
                Console.Write(s3[i]);
            Console.WriteLine();
            Stringstr str = new Stringstr();
            //str.Display();
            string S1 = " NEW YORK";
            string S2 = S1.Substring(5);
            string S3 = S1.Substring(1, 4);
            string S4 = S1.Substring(3, 4);
            Console.WriteLine(S2);
            Console.WriteLine(S3);
            Console.WriteLine(S4);
        }
        public void Display()
        {
            string? str1 = "";
            Console.Write("Enter a string :");
            str1 = Console.ReadLine();
            string? str2 = "";
            Console.Write("enter another string string ");
            str2 = Console.ReadLine();
            string str3 = "C# 2005 is developed in Visual Studio 2005 IDE";
            Console.WriteLine("String str3 is : {0}", str3);
            string str5 = string.Copy(str2);
            Console.WriteLine("String str5 is copied from str2: {0}", str5);
            Console.WriteLine("\n String str5 is {0} characters long.", str5.Length);
            Console.WriteLine("The 10th character of string str3 is:{0}", str3[9]);
            Console.WriteLine("String str3:{0} \n Ends with IDE?:{1}\n", str3, str3.EndsWith("IDE"));
            Console.WriteLine("Ends with studio?: {0}", str3.EndsWith("studio"));
            Console.WriteLine("\n The first time character 'a' occured in string str1 at position: {0}", str1.IndexOf("a") + 1);
            string str6 = str2.Insert(6, "hello");
            Console.WriteLine("hello' is inserted in string str6. String s6 is now: {0} \n", str6);


        }
    }*/

    /*class Struilder
    {
        public static void Main()
        {
            Struilder s11 = new Struilder();
            s11.nigga();


            StringBuilder s = new StringBuilder("Object");
            Console.WriteLine("Original string :" + s);
            Console.WriteLine("Length : " + s.Length);
            s.Append("language");
            Console.WriteLine("string now " + s);
            s.Insert(7, "oriented");
            int n = s.Length;
            s[n - 1] = '!';
            Console.WriteLine("Final string :" + s);
            
         

            

        }
        public void nigga()
        {
            string? str1 = "";
            string? str2 = "";
            Console.Write(" enter a string : ");
            str1 = Console.ReadLine();
            Console.Write("another string : ");
            str2 = Console.ReadLine();
            StringBuilder builder1 = new StringBuilder(str1, 4);
            StringBuilder builder2 = new StringBuilder(str2, 4);
            int cap = builder1.EnsureCapacity(55);
            Console.Write("string str1 appended to : ");
            builder1.Append(". This is a class test.");
            Console.WriteLine(builder1);
            Console.Write("String str2 inserted with");
            builder2.Insert(2, "String Builder");
            Console.WriteLine(builder2);
            Console.WriteLine("\n Second Character of string2 removed.\n");
            builder2.Remove(2, 4);
            Console.WriteLine(builder2);
            builder1.Replace(' ', '*');
            Console.WriteLine("\n Spaces removed from string1 \n");
            Console.WriteLine(builder1);
            Console.WriteLine("\nLength of string1 is : " + builder1.Length.ToString());
            Console.WriteLine("\nLength of string2 is : " + builder2.Length.ToString());
        }
        public void regexx()
        {
            
        }
    }*/
/*    class Regexx
    {
        public static void Main()
        {
            string str;
            str = "Ram, Shyam, Antony are friends!";
            Regex reg = new Regex("|,");
            StringBuilder sb = new StringBuilder();
            int count = 1;
            foreach (string sub in reg.Split(str))
            {
                sb.AppendFormat("{0}: {1}\n", count++, sub);
            }
            Console.WriteLine(sb);
        }
    }*/
    /*class Errordec
    {
           static void ShowArray(ref int[] intArray) { 
            if(intArray == null)
            {
                intArray = new int[10];
            }
            intArray[1] = 13;
            intArray[4] = 15;
            }
        static void Main()
        {
            int[] arrObj = { 3, 5, 7, 9, 11 };
            ShowArray(ref arrObj);  // enter ref if there is ref in call function
            System.Console.WriteLine("Elements sof te Array are: ");
            for (int i = 0; i < arrObj.Length; i++)
            {
                System.Console.WriteLine(arrObj[i] + " ");
            }
        }
    }*/
    
/*    class Loops
    {
        public static void Main()
        { int count = 0;
 
            for(int i = 0; i <40;i++)
            {
                Console.Write("*");
                if (i == 19)
                {
                    Console.WriteLine();
                    Console.WriteLine("C# programming");

                }
                count++;
            }
            Console.WriteLine();
            Console.WriteLine("Length of star is {0}", count);
        }
    }*/
/*    class Arrange
    {
        public static void Main()
        {
            int[] arr = { 9, 1, 4, 2, 3 };
            Arrange ar = new Arrange();
            ar.ascendi(ref arr);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("**************");
            ar.descendi(ref arr);
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
        public void ascendi(ref int[] arra)
        {
            int temp;
            for(int i = 0; i < arra.Length-1; i++)
            {   for(int j = 0; j< arra.Length - 1; j++)
                {
                    if (arra[j] > arra[j + 1])
                    {
                        temp = arra[j];
                        arra[j] = arra[j + 1];
                        arra[j+1] = temp;
                    }

                }
            }

        }
        public void descendi(ref int[] arra)
        {
            int temp;
            for (int i = 0; i < arra.Length - 1; i++)
            {
                for (int j = 0; j < arra.Length - 1; j++)
                {
                    if (arra[j] < arra[j + 1])
                    {
                        temp = arra[j];
                        arra[j] = arra[j + 1];
                        arra[j + 1] = temp;
                    }

                }
            }

        }


    }*/
    /*class Prime
    {
        public static void Main()
        {
            Prime p1 = new Prime();
            Console.Write("enter a number ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool xx;
            xx = p1.check(num);
            Console.WriteLine("it is prime = {0}", xx);
        }
        public bool check(int x)
        {
            int count=0;
            for (int i = 1; i <= x-1; i++) { 
                if(x%i == 0)
                {
                    count++;
                }
            }
            if (count < 2)
                return true;
            else
                return false;
        }
    }*/

/*    class Lararr
    {
        public static void Main()
        {
            Console.Write("num of data = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("array value = ");
            for(int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Lararr lar = new Lararr();

            lar.largest(arr);
            lar.average(arr);
        }
        public void largest(int[] arr)
        {
            int temp;
            int a = arr.Length;
            for (int i = 0; i < a - 1; i++)
            {
                for (int j = 0; j < a - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            }
            Console.WriteLine("largest = {0}", arr[0]);

        }
        public void average(int[] arr)
        {
            int nums = arr.Length;
            int a = 0;
            float avg=0f;
            foreach(int i in arr)
            {
                a += i;
            }
            avg = a / nums;
            Console.WriteLine("average = {0}", avg);
        }
    }*/

    class Test
    {
        public static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Test t1 = new Test();
            out z = t1.product(a,b);
            Console.WriteLine(z);
        }
        public void product(int x,int y)
        {
            out int z;
            z = x * y;
        }
    }




} //namespace{}

