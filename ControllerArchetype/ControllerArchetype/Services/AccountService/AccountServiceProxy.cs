using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ControllerArchetype.Models;

namespace ControllerArchetype.Services.AccountService
{
    public class AccountServiceProxy : IAccountService
    {
        public IEnumerable<Account> FindAccounts()
        {
            throw new NotImplementedException();
        }
    }
}