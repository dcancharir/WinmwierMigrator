using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("pf_promotion_id", "pf_type", "pf_flag_id")]
public partial class promotion_flag
{
    [Key]
    public long pf_promotion_id { get; set; }

    [Key]
    public int pf_type { get; set; }

    [Key]
    public long pf_flag_id { get; set; }

    public int pf_flag_count { get; set; }

    [ForeignKey("pf_flag_id")]
    [InverseProperty("promotion_flags")]
    public virtual flag pf_flag { get; set; } = null!;
}
