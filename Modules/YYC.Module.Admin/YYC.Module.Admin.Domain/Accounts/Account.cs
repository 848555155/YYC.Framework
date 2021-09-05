using YYC.Module.Admin.Roles;

namespace YYC.Module.Admin.Accounts;

[Comment("账户")]
public class Account
{
    public Account(
                string name,
                string userName,
                string password)
    {
        Name = name;
        UserName = userName;
        Password = password;
    }

    [Comment("账户主键")]
    public Guid AccountId { get; set; }

    [Comment("姓名")]
    [Required]
    public string Name { get; set; }

    [Comment("用户名")]
    [Required]
    public string UserName { get; set; }

    [Comment("密码")]
    [Required]
    public string Password { get; set; }

    [Comment("虚拟删除标记")]
    [Required]
    public bool Deleted { get; set; } = false;

    public List<Role> Roles { get; set; }
}