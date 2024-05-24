using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace databasetoentityfinal.Models;

public partial class Employee
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }
}
