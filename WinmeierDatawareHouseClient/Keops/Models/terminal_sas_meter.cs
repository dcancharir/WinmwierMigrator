using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("tsm_terminal_id", "tsm_meter_code", "tsm_game_id", "tsm_denomination")]
[Index("tsm_delta_updating", "tsm_meter_code", Name = "IX_tsm_delta_updating_meter_code")]
public partial class terminal_sas_meter
{
    [Key]
    public int tsm_terminal_id { get; set; }

    [Key]
    public int tsm_meter_code { get; set; }

    [Key]
    public int tsm_game_id { get; set; }

    [Key]
    [Column(TypeName = "money")]
    public decimal tsm_denomination { get; set; }

    public long tsm_wcp_sequence_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime tsm_last_reported { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tsm_last_modified { get; set; }

    public long tsm_meter_value { get; set; }

    public long tsm_meter_max_value { get; set; }

    public long tsm_delta_value { get; set; }

    public long tsm_raw_delta_value { get; set; }

    public bool tsm_delta_updating { get; set; }

    [Column(TypeName = "money")]
    public decimal? tsm_sas_accounting_denom { get; set; }
}
