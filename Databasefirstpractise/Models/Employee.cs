using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Databasefirstpractise.Models;

public partial class Employee
{
    [Key]
    public int EmpId { get; set; }

    public int Salary { get; set; }
}
