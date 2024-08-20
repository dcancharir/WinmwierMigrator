using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("pf_promotion_id", "pf_type", "pf_flag_id")]
[Index("pf_flag_id", Name = "IX_promotion_flags_pf_flag_id")]
public partial class promotion_flag
{
    [Key]
    public long pf_promotion_id { get; set; }

    [Key]
    public int pf_type { get; set; }

    [Key]
    public long pf_flag_id { get; set; }

    public int? pf_flag_count { get; set; }

    public int? pf_flag_count_excluded { get; set; }
}
