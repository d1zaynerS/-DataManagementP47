using System;
using System.Collections.Generic;

namespace DataManagementP47.EF.Entities;

public partial class Sale
{
    public Guid Id { get; set; }

    public Guid EmployeeId { get; set; }

    public Guid ProductId { get; set; }

    public int Quantity { get; set; }

    public DateTime Moment { get; set; }
}
