using System;
using System.Collections.Generic;
using System.Text;

namespace Aula145_ExceptionExercise.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public void Deposit(double amount)
        {
            Console.WriteLine("not implemented yet");
        }
        public void withdraw(double amount) 
        {
            Console.WriteLine("not implemented yet");
        }
    }
}
