using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[PrimaryKey("ssa_today", "ssa_track_data")]
public partial class ms_site_synchronize_account
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime ssa_today { get; set; }

    [Key]
    [StringLength(50)]
    public string ssa_track_data { get; set; } = null!;
}
