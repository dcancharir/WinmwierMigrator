using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class cage_movement
{
    public long cgm_movement_id { get; set; }

    public int? cgm_terminal_cage_id { get; set; }

    public int? cgm_terminal_cashier_id { get; set; }

    public int? cgm_user_cage_id { get; set; }

    public int? cgm_user_cashier_id { get; set; }

    public int cgm_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime cgm_movement_datetime { get; set; }

    public int cgm_status { get; set; }

    public long? cgm_cashier_session_id { get; set; }

    public long? cgm_source_target_id { get; set; }

    public long? cgm_cage_session_id { get; set; }

    public long? cgm_related_movement_id { get; set; }

    public int? cgm_target_type { get; set; }

    public int? cgm_gaming_table_id { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? cgm_gaming_table_visits { get; set; }

    public long? cgm_mc_collection_id { get; set; }

    public int? cgm_cancellation_user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? cgm_cancellation_datetime { get; set; }

    public long? cgm_related_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? cgm_collection_datetime { get; set; }
}
