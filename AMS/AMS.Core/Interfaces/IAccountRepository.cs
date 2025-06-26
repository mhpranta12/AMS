using AMS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Core.Interfaces
{
    public interface IAccountRepository
    {
        void ExecuteAccountInsertSP(Account account);
    }
}
