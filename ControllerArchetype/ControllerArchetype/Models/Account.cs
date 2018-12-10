using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControllerArchetype.Models
{
    public class Account
    {
        public string AccountId { get; private set; }
        public string AccountNumber { get; private set; }
        public decimal Balance { get; set; }

        public Account(string accountId, string accountNumber, decimal balance)
        {
            AccountId = accountId;
            AccountNumber = accountNumber;
            Balance = balance;
        }
    }
}