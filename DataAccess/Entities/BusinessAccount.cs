using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class BusinessAccount
    {
        public string AccountNumber { get; private set; }
        public string Type { get; private set; }
        public decimal Balance { get; set; }

        public BusinessAccount(string accountNumber, string type, decimal balance)
        {
            AccountNumber = accountNumber;
            Type = type;
            Balance = balance;
        }
    }
}
