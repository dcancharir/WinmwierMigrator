using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class group_element
{
    [Key]
    public long ge_id { get; set; }

    public int ge_element_type { get; set; }

    public long ge_element_id { get; set; }

    public long ge_group_id { get; set; }

    public string ge_query { get; set; } = null!;

    [ForeignKey("ge_group_id")]
    [InverseProperty("group_elements")]
    public virtual group ge_group { get; set; } = null!;
}
