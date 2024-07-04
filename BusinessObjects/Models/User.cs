﻿namespace BusinessObjects.Models;


/// <summary>
/// Người dùng
/// </summary>
public partial class User
{
    public int UserId { get; set; }
    public int RoleId { get; set; }
    public int? CounterId { get; set; }
    public string? Code { get; set; }
    public string? FullName { get; set; }
    public string? Gender { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public bool Status { get; set; }

    public DateTimeOffset? CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public virtual ICollection<Bill> Bills { get; set; } = [];
    public virtual Counter? Counter { get; set; }
    public virtual ICollection<Purchase> Purchases { get; set; } = [];
}
