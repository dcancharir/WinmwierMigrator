using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("hto_gaming_day", "hto_site_id", "hto_hour")]
[Table("hourly_take_out")]
public partial class hourly_take_out
{
    [Key]
    public int hto_gaming_day { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime hto_hour { get; set; }

    [Key]
    public int hto_site_id { get; set; }

    [StringLength(50)]
    public string hto_site_name { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal hto_coin_in { get; set; }

    [Column(TypeName = "money")]
    public decimal hto_take_out_pct { get; set; }

    [Column(TypeName = "money")]
    public decimal hto_take_out_win { get; set; }

    [Column(TypeName = "money")]
    public decimal hto_take_out_win_per_unit { get; set; }

    [Column(TypeName = "money")]
    public decimal hto_free_play { get; set; }

    public int hto_num_egm { get; set; }

    public int hto_num_sessions_female { get; set; }

    public int hto_num_sessions_male { get; set; }

    public int hto_num_sessions_anonymous { get; set; }

    public int hto_num_sessions_carded { get; set; }

    public int hto_num_sessions_uncarded { get; set; }

    public int hto_num_sessions_total { get; set; }

    public byte[] hto_timestamp { get; set; } = null!;
}
