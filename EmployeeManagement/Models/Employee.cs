using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models;

public partial class Employee
{
    [Key]
    public short Id { get; set; } 

    public string Name { get; set; } = null!;

    public string? Designation { get; set; }

    public long Salary { get; set; }

    public string? City { get; set; }
}
