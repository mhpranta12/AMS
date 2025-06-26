using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Service
{
    public interface IAccountService
    {
        public void CreateNewAccount(string name, string? userType, string? accountType,
            decimal? cash, decimal? recieveable, Guid? parentAccountId);
    }
}
