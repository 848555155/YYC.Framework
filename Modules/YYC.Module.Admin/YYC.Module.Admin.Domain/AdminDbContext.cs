global using Microsoft.EntityFrameworkCore;
using YYC.Module.Admin.Accounts;
namespace YYC.Module.Admin;
public class AdminDbContext : DbContext
{
    public AdminDbContext(DbContextOptions<AdminDbContext> options)
        : base(options)
    {
    }

    public DbSet<Account> Accounts { get; set; }
}