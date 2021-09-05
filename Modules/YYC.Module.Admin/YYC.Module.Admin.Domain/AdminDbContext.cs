global using Microsoft.EntityFrameworkCore;
global using System.ComponentModel.DataAnnotations;
using YYC.Module.Admin.Accounts;
namespace YYC.Module.Admin;
public class AdminDbContext : DbContext
{
    public AdminDbContext(DbContextOptions<AdminDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>()
            .Property(b => b.Name)
            .IsRequired();
    }

    public DbSet<Account> Accounts { get; set; }
}