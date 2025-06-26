using AMS.Core.Entities;
using AMS.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Service
{
    public class AccountService:IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public void CreateNewAccount(string name, string? userType,string? accountType,
            decimal? cash,decimal? recieveable, Guid? parentAccountId)
        {
            Account account = new Account()
            {
                Id=Guid.NewGuid(),
                Name = name,
                UserType = userType,
                AccountType = accountType,
                Cash = cash,
                Recieveable = recieveable,
                ParentAccountId = parentAccountId
            };
            _accountRepository.ExecuteAccountInsertSP(account);
        }
    }
}
