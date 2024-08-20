using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("tsmh_terminal_id", "tsmh_meter_code", "tsmh_game_id", "tsmh_denomination", "tsmh_type", "tsmh_datetime")]
[Table("terminal_sas_meters_history")]
[Index("tsmh_datetime", "tsmh_type", Name = "IX_tsmh_datetime_type")]
[Index("tsmh_type", "tsmh_meter_code", "tsmh_datetime", Name = "IX_tsmh_type_code_datetime")]
public partial class terminal_sas_meters_history
{
    [Key]
    public int tsmh_terminal_id { get; set; }

    [Key]
    public int tsmh_meter_code { get; set; }

    [Key]
    public int tsmh_game_id { get; set; }

    [Key]
    [Column(TypeName = "money")]
    public decimal tsmh_denomination { get; set; }

    [Key]
    public int tsmh_type { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime tsmh_datetime { get; set; }

    public long? tsmh_meter_ini_value { get; set; }

    public long tsmh_meter_fin_value { get; set; }

    public long tsmh_meter_increment { get; set; }

    public long tsmh_raw_meter_increment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tsmh_last_reported { get; set; }

    [Column(TypeName = "money")]
    public decimal? tsmh_sas_accounting_denom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tsmh_created_datetime { get; set; }

    public long? tsmh_group_id { get; set; }

    public int? tsmh_meter_origin { get; set; }

    public long? tsmh_meter_max_value { get; set; }

    public int? tsmh_no_rollover { get; set; }
}
