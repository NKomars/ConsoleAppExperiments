﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ConsoleAppExperiments
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> persons = new List<Human>();

            persons.Add(new Human("Ņiķita", "Komars", 20, "Brown"));
            persons.Add(new Human("Anna", "Liepa", 16, "Blue"));
            persons.Add(new Human("Michael", "Johnson", 14, "Green"));
            persons.Add(new Human("Agnese", "Egle", 19, "Gray"));

            //persons[1].SetAge(15);
                       
            foreach (var person in persons)
            {
                person.Introduce();
            }

            //create some accounts here
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new BankAccount("Jenifer", 200, "EUR"));
            accounts.Add(new BankAccount("Anna", 5000, "EUR"));
            accounts.Add(new BankAccount("Michael", 30, "EUR"));

            foreach (var account in accounts)
            {
                account.PrintInfo();
            }

            //make some transactions on Jenifer's account
            accounts[0].MakeDeposit(-100, "birthday gift");
            accounts[0].MakeDeposit(400, "first salary");
            accounts[0].MakeDeposit(50, "Bonus");
            Console.WriteLine(accounts[0].Balance);
            accounts[0].MakeWithdrawal(1500, "Online course");
            Console.WriteLine(accounts[0].Balance);
            
        }
    }

   
}
