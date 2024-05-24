using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DemoEntity.Models;

public partial class Demo
{
    [Key]
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;
}
