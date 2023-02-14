using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Plabon",100);
            Console.WriteLine($"account  {account.Number}  has create for {account.Owner}  with {account.Balance} !!!!!!!!! ");
            //account.MakeDiposit(10,DateTime.Now,"Mr Plabon");
            account.MakeWithdrawal(10, DateTime.Now, "Mr Plabon");
            Console.WriteLine(account.Balance);
            Console.ReadLine();
        }
    }
}
