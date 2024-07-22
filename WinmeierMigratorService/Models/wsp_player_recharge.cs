using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Table("wsp_player_recharge")]
public partial class wsp_player_recharge
{
    [Key]
    public long wpr_unique_id { get; set; }

    public long wpr_account_id { get; set; }

    [Column(TypeName = "money")]
    public decimal wpr_nr_amount { get; set; }

    /// <summary>
    /// 1 - Pending; 2 - In Progress; 3 - Error; 4 - Ok; 5 - Timeout
    /// </summary>
    public int wpr_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime wpr_created { get; set; }
}
