using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("tsmmh_terminal_id", "tsmmh_game_id", "tsmmh_denomination_id", "tsmmh_datetime")]
[Table("terminal_sas_meters_msg_history")]
public partial class terminal_sas_meters_msg_history
{
    [Key]
    public int tsmmh_terminal_id { get; set; }

    [Key]
    public int tsmmh_game_id { get; set; }

    [Key]
    public int tsmmh_denomination_id { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime tsmmh_datetime { get; set; }

    public Guid tsmmh_config_id { get; set; }

    public Guid tsmmh_values_id { get; set; }
}
