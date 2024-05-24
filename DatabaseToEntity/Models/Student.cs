using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseToEntity.Models;

public partial class Student
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string SirName { get; set; } = null!;
}
