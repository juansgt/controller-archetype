using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ControllerArchetype.Models;

namespace ControllerArchetype.Services.AccountService
{
    public class AccountServiceMock : IAccountService
    {
        public IEnumerable<Account> FindAccounts()
        {
            List<Account> accounts = new List<Account>();

            accounts.Add(new Account("1", "ES9420805801101234567891", 424));
            accounts.Add(new Account("2", "ES9420805801101834565812", 424));

            return accounts;
        }
    }
}