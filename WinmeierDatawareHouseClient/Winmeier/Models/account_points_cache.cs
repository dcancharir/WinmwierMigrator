using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Table("account_points_cache")]
public partial class account_points_cache
{
    [Key]
    public long apc_account_id { get; set; }

    public int apc_days { get; set; }

    [Column(TypeName = "money")]
    public decimal apc_history_points_generated_for_level { get; set; }

    [Column(TypeName = "money")]
    public decimal apc_history_points_discretional_for_level { get; set; }

    [Column(TypeName = "money")]
    public decimal apc_history_points_discretional_only_for_redeem { get; set; }

    [Column(TypeName = "money")]
    public decimal apc_history_points_promotion_only_for_redeem { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? apc_today { get; set; }

    [Column(TypeName = "money")]
    public decimal? apc_today_points_generated_for_level { get; set; }

    [Column(TypeName = "money")]
    public decimal? apc_today_points_discretional_for_level { get; set; }

    [Column(TypeName = "money")]
    public decimal? apc_today_points_discretional_only_for_redeem { get; set; }

    [Column(TypeName = "money")]
    public decimal? apc_today_points_promotion_only_for_redeem { get; set; }

    public long? apc_today_last_movement_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? apc_today_last_updated { get; set; }
}
