using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        { 
            get 
            {
                decimal balance = 0;
                foreach (var item in allTransaction)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        private static int accountNumberseed = 1234567890;

       private List<Transaction>allTransaction=new List<Transaction>();
     public BankAccount(string name,decimal initialbalance)
        {
            this.Owner = name;
            MakeDiposit(initialbalance,DateTime.Now ,"Initialbalance");
            this.Number = accountNumberseed.ToString();
            accountNumberseed++;
        }

     public void MakeDiposit(decimal amount,DateTime date,String notes)
        {
            if (amount<=0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount,date,notes);
            allTransaction.Add(deposit);
        }
        public void MakeWithdrawal(decimal amount, DateTime date, String notes)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if(Balance-amount<0)
            {
                throw new InvalidOperationException("Not balance for withdrawal !!!");

            }
            var withdrawal=new Transaction(amount,date,notes);
            allTransaction.Add(withdrawal);

        }

    }
}
