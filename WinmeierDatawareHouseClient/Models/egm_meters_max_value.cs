using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[PrimaryKey("emmv_site_id", "emmv_terminal_id", "emmv_meter_code", "emmv_game_id", "emmv_denomination", "emmv_type", "emmv_datetime")]
public partial class egm_meters_max_value
{
    [Key]
    public long emmv_site_id { get; set; }

    [Key]
    public int emmv_terminal_id { get; set; }

    [Key]
    public int emmv_meter_code { get; set; }

    [Key]
    public int emmv_game_id { get; set; }

    [Key]
    [Column(TypeName = "money")]
    public decimal emmv_denomination { get; set; }

    [Key]
    public int emmv_type { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime emmv_datetime { get; set; }

    public long? emmv_max_value { get; set; }
}
