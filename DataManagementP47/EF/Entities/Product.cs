using System;
using System.Collections.Generic;

namespace DataManagementP47.EF.Entities;

public partial class Product
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public override string ToString()
    {
        String first3 = Id.ToString()[..3];
        String last3 = Id.ToString()[^3..];
        return $"{first3}..{last3} {Name}  ₴{Price:F2}";
    }

}
