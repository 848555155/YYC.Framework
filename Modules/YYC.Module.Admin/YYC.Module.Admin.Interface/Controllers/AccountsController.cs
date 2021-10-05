using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace YYC.Module.Admin.Accounts;

[ApiController]
[Route("admin/[controller]")]
public class AccountsController : ControllerBase
{
    private readonly IAccountsService _service;

    public AccountsController(IAccountsService service)
    {
        _service = service;
    }

    [HttpGet]
    public Task<List<Account>> GetAccounts()
    {
        return _service.GetAsync();
    }

    [HttpGet("{accountId}")]
    public Task<Account> GetAccount(Guid accountId)
    {
        return _service.GetAsync(accountId);
    }
}
