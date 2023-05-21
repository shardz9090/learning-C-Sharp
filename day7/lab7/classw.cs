using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    /*class Animal
    {
        public string? Name;
        public int age;
        public Animal(string Name, int age)
        {
            this.Name = Name;
            this.age = age;
        }
        public virtual void Display()
        {
            Console.WriteLine("Name = {0} , Age = {1} ", this.Name, this.age);
        }
    }
    class Cat : Animal
    {
        public Cat(string Name, int age): base(Name, age) { }
        public override void Display()
        {
            Console.WriteLine("{0} {1}",this.Name,this.age);
        }
    }
    class Dog : Animal
    {
        public Dog(string Name, int age) : base(Name, age) { }
        public override void Display()
        {
            Console.WriteLine("{0} {1}",this.Name,this.age);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Animal an = new Animal("Mishra", 12);
            Animal c = new Cat("Gullu", 22);
            Animal d = new Dog("Shardul", 90);
            c.Display();
            d.Display();

        }
    }*/

    /*class Person
    {
        public string? name;
        public int age;
        public string? sex;
        public Person(string Name, int a, string s)
        {
            name = Name;
            age = a;
            sex = s;
        }
        public virtual void Display()
        {
            Console.WriteLine("{0} {1} {2} ", name,age,sex);
        }
    }
    class Employee : Person
    {
        public string? code;

        public Employee(string Name, int age, string sex, string c):base(Name,age,sex) {
            code = c;
        }
        public override void Display()
        {
            Console.WriteLine("Name = {0}   Age = {1}   Sex = {2}   Code = {3}", name, age, sex, code);
        }
    }
    class Specialist : Employee
    {
        public Specialist(string Name, int age, string sex, string c) : base(Name, age, sex, c) {
            code = c;
        }

        public override void Display()
        {
            Console.WriteLine("Name = {0}   Age = {1}   Sex = {2}   Code = {3}", name, age, sex, code);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Employee[] e = new Employee[3];
            e[0] = new Employee("Shardul", 22, "male", "09A98");
            e[1] = new Employee("Shaardul", 222, "male", "09A98");
            e[2] = new Employee("Shaaardul", 2222, "male", "09A98");

            Specialist[] s = new Specialist[3];
            s[0] = new Specialist("Shaaardul", 22222, "male", "109A98");
            s[1] = new Specialist("Shaaaaardul", 222222, "male", "209A98");
            s[2] = new Specialist("Shaaaaaardul", 22222222, "male", "309A98");

            Console.WriteLine("***********Employee***********");
            foreach(Employee ee in e)
            {
                ee.Display();
            }
            Console.WriteLine("***********Specialist***********");
            foreach (Specialist ss in s)
            {
                ss.Display();
            }
        }
    }*/
}
