using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("tsmph_id", "tsmph_datetime", "tsmph_terminal_id", "tsmph_meter_code", "tsmph_game_id", "tsmph_denomination", "tsmph_type")]
[Table("terminal_sas_meters_pre_history")]
public partial class terminal_sas_meters_pre_history
{
    [Key]
    public long tsmph_id { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime tsmph_datetime { get; set; }

    [Key]
    public int tsmph_terminal_id { get; set; }

    [Key]
    public int tsmph_meter_code { get; set; }

    [Key]
    public int tsmph_game_id { get; set; }

    [Key]
    [Column(TypeName = "money")]
    public decimal tsmph_denomination { get; set; }

    [Key]
    public int tsmph_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tsmph_datetime_daily { get; set; }

    public long? tsmph_meter_ini_value { get; set; }

    public long tsmph_meter_fin_value { get; set; }

    public long tsmph_meter_increment { get; set; }

    public long tsmph_raw_meter_increment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tsmph_last_reported { get; set; }

    [Column(TypeName = "money")]
    public decimal? tsmph_sas_accounting_denom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tsmph_created_datetime { get; set; }

    public long? tsmph_group_id { get; set; }

    public int? tsmph_meter_origin { get; set; }

    public long? tsmph_meter_max_value { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tsmph_next_datetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tsmph_next_datetime_daily { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tsmph_hourly_disconnection_event { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tsmph_daily_disconnection_event { get; set; }
}
