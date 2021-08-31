using System;

namespace Bank
{
    public class Program
    {
        static void Main()
        {
            /* wypłaty
*/
            var account = new Account("John");
            account.Deposit(100.00m);
            Console.WriteLine(account.Withdrawal(10.00m));
            Console.WriteLine(account);
            Console.WriteLine(account.Withdrawal(100.00m));
            Console.WriteLine(account);
            Console.WriteLine(account.Withdrawal(0.00m));
            Console.WriteLine(account);
            Console.WriteLine(account.Withdrawal(-10.00m));
            Console.WriteLine(account);
            account.Block();
            Console.WriteLine(account.Withdrawal(10.4999m));
            Console.WriteLine(account);
        }
    }
    public interface IAccount
    {
        // nazwa klienta, bez spacji przed i po
        // readonly - modyfikowalna wyłącznie w konstruktorze
        string Name { get; }

        // bilans, aktualny stan środków, podawany w zaokrągleniu do 2 miejsc po przecinku
        decimal Balance { get; }

        // czy konto jest zablokowane
        bool IsBlocked { get; }
        void Block();            // zablokowanie konta
        void Unblock();          // odblokowanie konta

        // wpłata, dla kwoty ujemnej - zignorowana (false)
        // jeśli konto zablokowane - zignorowana (false)
        // true jeśli wykonano i nastąpiła zmiana salda
        bool Deposit(decimal amount);

        // wypłata, dla kwoty ujemnej - zignorowana (false)
        // jeśli konto zablokowane - zignorowana (false)
        // jeśli jest niewystarczająca ilość środków - zignorowana (false)
        // true jeśli wykonano i nastąpiła zmiana salda   
        bool Withdrawal(decimal amount);
    }
    
}