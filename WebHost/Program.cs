using Microsoft.EntityFrameworkCore;
using YYC.Module.Admin;
using YYC.Module.Admin.Accounts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var admin = builder.Configuration.GetConnectionString("Admin");
builder.Services.AddTransient<IAccountsRepository, AccountsRepository>();
builder.Services.AddTransient<IAccountsService, AccountsService>();
builder.Services.AddDbContext<AdminDbContext>(opt =>
    opt.UseNpgsql(admin));

var app = builder.Build();
app.UseMiddleware<ExceptionMiddleware>();
// app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
