using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControllerArchetype.Models
{
    public class Account
    {
        public string AccountNumber { get; private set; }
        public decimal balance { get; set; }

        public Account(string accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            this.balance = balance;
        }
    }
}