using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Index("ge_group_id", Name = "IX_group_elements_ge_group_id")]
public partial class group_element
{
    [Key]
    public long ge_id { get; set; }

    public int ge_element_type { get; set; }

    public long ge_element_id { get; set; }

    public long ge_group_id { get; set; }

    public string ge_query { get; set; } = null!;
}
