﻿using EjemploCuentaBank;
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("<name>", 1000);
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);

        // Test that the initial balances must be positive.
        BankAccount invalidAccount;
        try
        {
            invalidAccount = new BankAccount("invalid", -55);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("Exception caught creating account with negative balance");
            Console.WriteLine(e.ToString());
            return;
        }
    }
    }
