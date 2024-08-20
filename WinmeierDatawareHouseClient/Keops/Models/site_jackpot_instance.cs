using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class site_jackpot_instance
{
    [Key]
    public int sji_index { get; set; }

    [StringLength(20)]
    public string sji_name { get; set; } = null!;

    [Column(TypeName = "numeric(5, 2)")]
    public decimal sji_contribution_pct { get; set; }

    [Column(TypeName = "money")]
    public decimal sji_minimum { get; set; }

    [Column(TypeName = "money")]
    public decimal sji_maximum { get; set; }

    [Column(TypeName = "money")]
    public decimal sji_average { get; set; }

    [Column(TypeName = "numeric(20, 8)")]
    public decimal sji_accumulated { get; set; }

    public int sji_num_pending { get; set; }

    [Column(TypeName = "money")]
    public decimal sji_minimum_bet { get; set; }

    public long? sji_bonus_id { get; set; }

    public bool? sji_show_on_winup { get; set; }
}
