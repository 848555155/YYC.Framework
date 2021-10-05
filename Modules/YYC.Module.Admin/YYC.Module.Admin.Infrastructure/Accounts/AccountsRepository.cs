using System.Linq;
using System.Threading.Tasks;

namespace YYC.Module.Admin.Accounts;

public class AccountsRepository: IAccountsRepository
{
    private readonly DbSet<Account> _accounts;
    public AccountsRepository(AdminDbContext context)
    {
        _accounts = context.Accounts;
    }

    public Task<List<Account>> GetAsync() 
    {
        return _accounts
                .Where(account => account.Deleted == false)
                .ToListAsync();
    }

    public Task<Account?> GetAsync(Guid accountId)
    {
        return _accounts
                .Where(account => account.Deleted == false)
                .SingleOrDefaultAsync(a => a.AccountId == accountId);
    }
}