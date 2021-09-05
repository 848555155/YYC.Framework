using YYC.Module.Admin.Accounts;

namespace YYC.Module.Admin.Roles;

[Comment("角色")]
public class Role
{
    [Comment("角色主键")]
    public Guid RoleId { get; set; }

    public List<Account> Accounts { get; set; }
}