using Container;
using ControllerArchetype.Models;
using ControllerArchetype.Services.AccountService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Unity;

namespace ControllerArchetype.Controllers
{
    public class AccountsController : ApiController
    {
        // GET: api/Accounts
        [HttpGet]
        [Route("accounts")]
        public IEnumerable<Account> GetAccounts()
        {
            IAccountService accountService = ContainerService.Instance.GetUnityContainer().Resolve<IAccountService>();

            return accountService.FindAccounts();
        }

        // GET: api/Accounts/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Accounts
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Accounts/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Accounts/5
        public void Delete(int id)
        {
        }
    }
}
