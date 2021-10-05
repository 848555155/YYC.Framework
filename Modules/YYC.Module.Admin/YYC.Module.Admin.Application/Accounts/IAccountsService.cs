using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace YYC.Module.Admin.Accounts;

public interface IAccountsService
{
    Task<List<Account>> GetAsync();

    Task<Account> GetAsync(Guid accountId);
}
