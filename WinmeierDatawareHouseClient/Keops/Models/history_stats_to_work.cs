using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("hsw_day_to_process", "hsw_type")]
[Table("history_stats_to_work")]
public partial class history_stats_to_work
{
    [Key]
    public int hsw_day_to_process { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string hsw_type { get; set; } = null!;
}
