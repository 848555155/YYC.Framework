global using Microsoft.EntityFrameworkCore;
global using System.ComponentModel.DataAnnotations;
using YYC.Module.Admin.Accounts;
using YYC.Module.Admin.Roles;

namespace YYC.Module.Admin;
public class AdminDbContext : DbContext
{
    public AdminDbContext(DbContextOptions<AdminDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }

    public DbSet<Account> Accounts { get; set; }

    public DbSet<Role> Roles { get; set; }
}