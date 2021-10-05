using System;
using System.Collections.Generic;
using YYC.Module.Admin.Accounts;

namespace YYC.Module.Admin.Roles;

[Comment("角色")]
public class Role
{
    [Comment("角色主键")]
    public Guid RoleId { get; set; }

    [Comment("角色名")]
    [Required]
    public string Name { get; set; }

    public List<Account> Accounts { get; set; }
}