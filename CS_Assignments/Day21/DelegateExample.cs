using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day21
{
    public delegate void mydelegate();
    public class Bank
    {
        public double AccBalance;
        public double total_bal;
        public event mydelegate Lowbalance;
        public event mydelegate Unsufficientbal;
        public Bank(double AccBalance)
        {
            this.AccBalance = AccBalance;
            Console.WriteLine($"Current Account Balance is Rs. {AccBalance}");
        }

        public void Credit(double CreditAmount)
        {
            total_bal = AccBalance + CreditAmount;

            Console.WriteLine($"Your Total Balance is Rs. {total_bal}");
        }

        public void Debit(double wa)
        {
           
            if (wa > total_bal)
            {
                Lowbalance();
            }
            else if (total_bal - wa < 5000)
            {
                Unsufficientbal();
            }
            else
            {
                double amountleft = total_bal - wa;
                Console.WriteLine($"Remaining Amount is Rs. {amountleft}");

            }
        }
    }

    public class DelegateExample
    {

        static void Lowbalance()
        {
            Console.WriteLine("your acc balance low");
        }

        static void Unsufficientbal()
        {
            Console.WriteLine("min amount limit reached");
        }
        static void Main(string[] args)

        {
            Bank b1 = new Bank(10000);

            b1.Lowbalance += new mydelegate(Lowbalance);
            b1.Unsufficientbal += new mydelegate(Unsufficientbal);

            Console.WriteLine("enter amount to credit");
            double credit = Convert.ToDouble(Console.ReadLine());

            b1.Credit(credit);

            Console.WriteLine("enter amount to debit");
            double debit = Convert.ToDouble(Console.ReadLine());

            b1.Debit(debit);



        }


    }
}
