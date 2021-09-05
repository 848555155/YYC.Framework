namespace YYC.Module.Admin.Accounts;
public interface IAccountsRepository
{
    Task<List<Account>> GetAsync();

    Task<Account?> GetAsync(Guid accountId);
}