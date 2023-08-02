using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;
        private double SSN;

        public string Name { get; set; }
        


        public double Deposit(double deposit)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            return _balance += deposit;
            
        }
        public double GetBalance() 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return _balance;
        }
        
        public double Withdrawal(double withdrawal)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            return _balance -= withdrawal;
        }

        
    }
}
