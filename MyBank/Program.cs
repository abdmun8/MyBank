using System;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Kendra", 0);
            Console.WriteLine($"{account.Owner} has Account {account.Number} with {account.Balance} balance" );
        }
    }
}
