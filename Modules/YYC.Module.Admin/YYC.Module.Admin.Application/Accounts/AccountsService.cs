namespace YYC.Module.Admin.Accounts;

public class AccountsService: IAccountsService
{
    private readonly IAccountsRepository _repository;
    public AccountsService(IAccountsRepository Repository)
    {
        _repository = Repository;
    }

    public Task<List<Account>> GetAsync()
    {
        return _repository.GetAsync();
    }

    public async Task<Account> GetAsync(Guid accountId)
    {
        var account = await _repository.GetAsync(accountId);
        if (account == null)
        {
            throw new Exception("资源未找到");
        }
        return account;
    }
}