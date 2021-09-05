namespace YYC.Module.Admin.Accounts;

[Comment("账户表")]
public class Account
{
    [Comment("账户主键")]
    public Guid AccountId { get; set; }

    [Comment("姓名")]
    public string Name { get; set; }
}