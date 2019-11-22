﻿using System;
using Aula145_ExceptionExercise.Entities.Exceptions;

namespace Aula145_ExceptionExercise.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw (new DomainException("Amount must be a positive value"));
            }
            Balance += (double)amount;
        }
        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw (new DomainException("Not enought balance"));
            }
            if (amount > WithdrawLimit)
            {
                throw (new DomainException("The amount exceed withdraw limit"));
            }
            Balance -= amount;
        }
    }
}
