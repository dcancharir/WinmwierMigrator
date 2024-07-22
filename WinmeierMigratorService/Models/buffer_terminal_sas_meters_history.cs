using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("btsmh_terminal_id", "btsmh_meter_code", "btsmh_game_id", "btsmh_denomination", "btsmh_type", "btsmh_datetime", "btsmh_timestamp")]
[Table("buffer_terminal_sas_meters_history")]
public partial class buffer_terminal_sas_meters_history
{
    [Key]
    public int btsmh_terminal_id { get; set; }

    [Key]
    public int btsmh_meter_code { get; set; }

    [Key]
    public int btsmh_game_id { get; set; }

    [Key]
    [Column(TypeName = "money")]
    public decimal btsmh_denomination { get; set; }

    [Key]
    public int btsmh_type { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime btsmh_datetime { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime btsmh_timestamp { get; set; }
}
