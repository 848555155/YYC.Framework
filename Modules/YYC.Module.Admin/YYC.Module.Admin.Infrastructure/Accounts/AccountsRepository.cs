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
                .ToListAsync();
    }

    public Task<Account?> GetAsync(Guid accountId)
    {
        return _accounts
                .SingleOrDefaultAsync(a => a.AccountId == accountId);
    }
}