using System;
using System.Collections.Generic;

namespace EntityFreamworkBD.Models;

public partial class Employee
{
    public long EmployeeId { get; set; }

    public int CompanyId { get; set; }

    public DateTime? CreateOn { get; set; }

    public DateTime? DeleteOn { get; set; }

    public string Email { get; set; } = null!;

    public string? Fax { get; set; }

    public string? Name { get; set; }

    public DateTime? LastLogin { get; set; }

    public string Passwrod { get; set; } = null!;

    public int PortalId { get; set; }

    public int RoleId { get; set; }

    public int StatusId { get; set; }

    public string? Telephone { get; set; }

    public DateTime? UpdateOn { get; set; }

    public string UserName { get; set; } = null!;
}
