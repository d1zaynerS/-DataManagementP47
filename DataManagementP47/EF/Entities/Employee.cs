using System;
using System.Collections.Generic;

namespace DataManagementP47.EF.Entities;

public partial class Employee
{
    public Guid Id { get; set; }

    public Guid FirmId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime Birthdate { get; set; }
}
