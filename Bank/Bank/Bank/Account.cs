using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Account : IAccount
    {
        private decimal balance;
        public string Name { get; }
        public decimal Balance
        {
            get => Math.Round(balance, 4);
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    balance = value;
                }
            }
        }
        public bool IsBlocked { get; set; }
        public Account(string name, decimal balance = 0.00m) // 0.00m !!!!!!
        {
            if (string.IsNullOrEmpty(name) || balance < 0) throw new ArgumentOutOfRangeException();

            if (name.Trim().Length < 3) throw new ArgumentException();
            else Name = name.Trim();

            Balance = balance;
            IsBlocked = false;
        }
        public void Block() => IsBlocked = true;
        public void Unblock() => IsBlocked = false;
        public bool Deposit(decimal amount)
        {
            if (amount < 0 || IsBlocked == true) return false;
            else
            {
                Math.Round((balance += amount), 4);
                return true;
            }
        }
        public bool Withdrawal(decimal amount)
        {
            if (amount <= 0 || IsBlocked == true || balance - amount < 0) return false;
            else
            {
                Math.Round((balance -= amount), 4);
                return true;
            }
        }
        public override string ToString()
        {
            if (IsBlocked == true)
            {
                return $"Account name: {Name}, balance: {Math.Round(Balance, 2)}, blocked";
            }
            else
            {
                return $"Account name: {Name}, balance: {Math.Round(Balance, 2)}";
            }
        }
    }
}
