using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class AccountPlus : Account, IAccountWithLimit
    {
        private decimal oneTimeDebetLimit;
        public new bool IsBlocked { get; private set; } = false;
        public decimal OneTimeDebetLimit {
            get => Math.Round(oneTimeDebetLimit, 4);
            set
            {
                if (IsBlocked == false && value > 0)
                {
                    AvaibleFounds -= oneTimeDebetLimit;
                    oneTimeDebetLimit = value;
                    AvaibleFounds += value;
                }
                if (value < 0) oneTimeDebetLimit = 0.00m;
            } 
        }
        public decimal AvaibleFounds { get; set; }
        public new void Block() => IsBlocked = true;
        public new void Unblock() { if (AvaibleFounds >= OneTimeDebetLimit) IsBlocked = false; }
        public AccountPlus(string name, decimal initialLimit = 100.00m, decimal initialBalance = 0.00m) : base(name, initialBalance)
        {
            if (initialLimit < 0) initialLimit = 0.00m;

            OneTimeDebetLimit = initialLimit;
            AvaibleFounds = initialBalance + initialLimit;
        }

        public new bool Deposit(decimal amount)
        {
            if (amount <= 0) return false;

            AvaibleFounds = Math.Round(AvaibleFounds += amount, PRECISION);
            if (AvaibleFounds - OneTimeDebetLimit >= 0) IsBlocked = false;
            return true;
        }

        public new bool Withdrawal(decimal amount)
        {
            if (amount <= 0 || amount > AvaibleFounds || IsBlocked) return false;

            AvaibleFounds = Math.Round(AvaibleFounds -= amount, PRECISION);
            if (AvaibleFounds - oneTimeDebetLimit < 0) IsBlocked = true;
            return true;
        }
        public override string ToString()
        {
            var balance = AvaibleFounds - OneTimeDebetLimit;
            if (balance < 0) balance = 0;

            return IsBlocked
                ? $"Account name: {Name}, balance: {balance:F2}, blocked, avaible founds: {AvaibleFounds:F}, limit: {OneTimeDebetLimit:F}"
                : $"Account name: {Name}, balance: {balance:F2}, avaible founds: {AvaibleFounds:F}, limit: {OneTimeDebetLimit:F}";
        }
    }
}
