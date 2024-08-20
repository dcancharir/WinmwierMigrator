using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("jmh_jackpot_id", "jmh_terminal_id", "jmh_type", "jmh_date")]
[Table("jackpots_meters_history")]
public partial class jackpots_meters_history
{
    [Key]
    public int jmh_jackpot_id { get; set; }

    [Key]
    public int jmh_terminal_id { get; set; }

    [Key]
    public int jmh_type { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime jmh_date { get; set; }

    [Column(TypeName = "money")]
    public decimal jmh_played_amount { get; set; }

    [Column(TypeName = "numeric(20, 8)")]
    public decimal jmh_meter_amount { get; set; }

    [Column(TypeName = "numeric(20, 8)")]
    public decimal jmh_compensation_amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime jmh_creation { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime jmh_last_update { get; set; }
}
