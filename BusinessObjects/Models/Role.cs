﻿namespace BusinessObjects.Models;

/// <summary>
/// Vai trò
/// </summary>
public partial class Role
{
    public int RoleId { get; set; }
    public string? RoleName { get; set; }
    public virtual ICollection<User> Users { get; set; } = [];
}
