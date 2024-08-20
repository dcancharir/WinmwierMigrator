using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class jackpots_happy_hour_prize
{
    public long jhhp_prizes_id { get; set; }

    public int jhhp_jackpot_id { get; set; }

    [Column(TypeName = "money")]
    public decimal jhhp_prize { get; set; }

    public int jhhp_quantity { get; set; }

    public int jhhp_position { get; set; }

    public byte? jhhp_group { get; set; }

    public byte? jhhp_type { get; set; }

    [Column(TypeName = "money")]
    public decimal? jhhp_minimum_bet { get; set; }
}
