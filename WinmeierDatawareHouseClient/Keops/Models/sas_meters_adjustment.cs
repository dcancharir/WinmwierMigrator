using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("tma_gaming_day", "tma_terminal_id", "tma_meter_code", "tma_game_id", "tma_denomination", "tma_unique_id")]
public partial class sas_meters_adjustment
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime tma_gaming_day { get; set; }

    [Key]
    public int tma_terminal_id { get; set; }

    [Key]
    public int tma_meter_code { get; set; }

    [Key]
    public int tma_game_id { get; set; }

    [Key]
    public int tma_denomination { get; set; }

    [Key]
    public long tma_unique_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime tma_datetime { get; set; }

    public int tma_type { get; set; }

    public int tma_sub_type { get; set; }

    public long tma_old_initial_value { get; set; }

    public long tma_old_final_value { get; set; }

    public long tma_old_delta_value { get; set; }

    public long tma_new_initial_value { get; set; }

    public long tma_new_final_value { get; set; }

    public long tma_new_delta_value { get; set; }

    public int tma_user_id { get; set; }

    public int tma_reason { get; set; }

    [StringLength(512)]
    public string? tma_remarks { get; set; }

    public int tma_old_no_rollover { get; set; }

    public int tma_new_no_rollover { get; set; }
}
