using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class group
{
    [Key]
    public long gr_id { get; set; }

    public int gr_content_type { get; set; }

    public int gr_type { get; set; }

    [StringLength(50)]
    public string gr_name { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime gr_updated { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gr_expanded { get; set; }

    [StringLength(255)]
    public string? gr_description { get; set; }

    public bool gr_enabled { get; set; }

    [InverseProperty("ge_group")]
    public virtual ICollection<group_element> group_elements { get; set; } = new List<group_element>();
}
