using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("c2_jackpot_history")]
public partial class c2_jackpot_history
{
    public long c2jh_jackpot_id { get; set; }

    public int c2jh_index { get; set; }

    [StringLength(40)]
    public string? c2jh_name { get; set; }

    public int c2jh_status { get; set; }

    [Column(TypeName = "money")]
    public decimal c2jh_amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime c2jh_awarded { get; set; }

    public long? c2jh_play_id { get; set; }

    public int c2jh_terminal_id { get; set; }

    [StringLength(100)]
    public string? c2jh_terminal_name { get; set; }

    public int c2jh_game_id { get; set; }

    [StringLength(100)]
    public string? c2jh_game_name { get; set; }
}
