using ControllerArchetype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerArchetype.Services.AccountService
{
    interface IAccountService
    {
        IEnumerable<Account> FindAccounts();
    }
}
