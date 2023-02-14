using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Account
    {
        public int accountID;
        public double accountBalance;
        public static int count=0;
        public void deposite (double amount)
        {
            accountBalance= amount;
            amount= Convert.ToDouble(Console.ReadLine());
        }
        public void withdraw(double amount1)
        {
            accountBalance= amount1;
            amount1= Convert.ToDouble(Console.ReadLine());
        }
        public void accountinfo(double amount2) 
        {

            Console.WriteLine("Diposite  :",deposite(amount));

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
