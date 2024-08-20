using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("btsm_terminal_id", "btsm_meter_code", "btsm_game_id", "btsm_denomination", "btsm_timestamp")]
public partial class buffer_terminal_sas_meter
{
    [Key]
    public int btsm_terminal_id { get; set; }

    [Key]
    public int btsm_meter_code { get; set; }

    [Key]
    public int btsm_game_id { get; set; }

    [Key]
    [Column(TypeName = "money")]
    public decimal btsm_denomination { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime btsm_timestamp { get; set; }
}
