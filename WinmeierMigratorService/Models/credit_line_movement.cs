using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Index("clm_credit_line_id", "clm_type", Name = "IDX_clm_credit_line_id")]
public partial class credit_line_movement
{
    [Key]
    public long clm_id { get; set; }

    public long clm_credit_line_id { get; set; }

    public long clm_operation_id { get; set; }

    public int clm_type { get; set; }

    [Column(TypeName = "xml")]
    public string? clm_old_value { get; set; }

    [Column(TypeName = "xml")]
    public string clm_new_value { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime clm_creation { get; set; }

    [StringLength(50)]
    public string clm_creation_user { get; set; } = null!;

    public byte[] clm_timestamp { get; set; } = null!;
}
