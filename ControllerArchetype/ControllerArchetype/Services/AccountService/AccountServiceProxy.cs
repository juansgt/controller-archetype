using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Container;
using ControllerArchetype.Models;
using DataAccess.AccountDao;
using DataAccess.Entities;
using Unity;

namespace ControllerArchetype.Services.AccountService
{
    public class AccountServiceProxy : IAccountService
    {
        public IEnumerable<Account> FindAccounts()
        {
            IAccountDao accountDao = ContainerService.Instance.GetUnityContainer().Resolve<IAccountDao>();
            List<Account> accounts = new List<Account>();

            foreach (BusinessAccount businessAccount in accountDao.FindAccounts())
            {
                accounts.Add(new Account(businessAccount.AccountId.ToString(), businessAccount.AccountNumber, businessAccount.Balance));
            }

            return accounts;
        }
    }
}