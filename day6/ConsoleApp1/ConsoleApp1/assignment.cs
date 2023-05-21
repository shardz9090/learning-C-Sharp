using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    
    class Timee
    {
        public int minutes;
        public int hours;
        public Timee(int x, int y)
        {
            minutes = y;
            hours = x;
        }
        public Timee(int x)
        {
            int lmin = x;
            this.hours = lmin / 60;
            this.minutes = lmin % 60;
        }
        public void Display()
        {
            Console.WriteLine("{0} : {1}",this.hours, this.minutes);
        }
        public void increase()
        {
            this.minutes += 1;
        }
        public void decrease()
        {
            this.minutes -= 1;
        }
    }


    //Bank account
    class Bank
    {
        public string name;
        public double accnum;
        public string type;
        public decimal amount;
        
        public Bank(string a, double b, string c, decimal d)
        {
            name = a;
            accnum = b;
            type = c;
            amount = d;
            Console.WriteLine("Name = {0} \nAccount Number = {1} \nAccount Type = {2} \nAmount Balance = {3}",name, accnum, type, amount);
        }
        public void deposit(decimal e)
        {
            decimal add = e;
            Console.WriteLine("{0} has been deposited to your account", add);
            this.amount += add;
            Console.WriteLine("New Amount Balance  = {0}", this.amount);
        }
        public void withdraw()
        {
            Console.WriteLine("The amount available in the account is NRs {0} : ", this.amount);
            Console.Write("Enter the amount to withdraw ");
            decimal wiam = Convert.ToDecimal(Console.ReadLine());
            if(this.amount - wiam < 0) {
                Console.WriteLine("Not enough balance");
            }
            else
            {
                Console.WriteLine("NRs {0} has been withdrawn from your accout", wiam);
                this.amount -= wiam;
                Console.WriteLine("New Amount Balance = Nrs {0}", this.amount);
            }
            
        }
        public void Display()
        {
            Console.WriteLine("Name = {0} \nAmount Balance = NRS {1}", this.name, this.amount);
        }
    }
    class Program
    {
        public static void Main()
        {      
            Timee t1 = new Timee(10, 50);
            t1.Display();

            Console.Write("Enter the large minute: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Timee t2 = new Timee(x);
            t2.Display();

            t2.increase();
            t2.Display();

            t2.decrease();
            t2.Display();


            decimal dep;
            Bank b = new Bank("Shardul Mishra", 123456543231, "Saving", 50000);
            Console.WriteLine("1. Deposit \n2. Withdraw \n3. Display \n4. Exit ");
        swt:
            Console.Write("Enter Choice = ");
            int ab = Convert.ToInt32(Console.ReadLine());
            switch (ab)
            {
                case 1:
                    Console.Write("enter the amount to deposit = ");
                    dep = Convert.ToDecimal(Console.ReadLine());
                    b.deposit(dep);
                    goto swt;

                case 2:
                    b.withdraw();
                    goto swt;
                case 3:
                    b.Display();
                    goto swt;
                case 4:
                    break;
            }


        }
    }

}