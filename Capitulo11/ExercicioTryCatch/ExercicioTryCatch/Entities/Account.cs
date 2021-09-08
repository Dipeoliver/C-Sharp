using System;
using System.Collections.Generic;
using ExercicioTryCatch.Entities.DomainExcepetion;

namespace ExercicioTryCatch.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit ( double amount)
        {
            if (amount > 0)
            {
                throw new DomainException("The amount must be greater than 0 reais ");
            }

            Balance += amount;
        }

        public void WithDraw(double amount)
        {

            if (amount > WithDrawLimit)
            {
                throw new DomainException("The Amount exceeds withdraw limit");
            } 

            if (amount > Balance && Balance > 0)
            {
                throw new DomainException("The Amount exceeds the Balance");
            }

            Balance -= amount;
        }       
    }
}
