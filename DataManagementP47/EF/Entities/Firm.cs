using System;
using System.Collections.Generic;

namespace DataManagementP47.EF.Entities;

public partial class Firm
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;
}