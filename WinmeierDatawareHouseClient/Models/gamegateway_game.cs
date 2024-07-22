using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[PrimaryKey("gg_game_id", "gg_partner_id")]
public partial class gamegateway_game
{
    [Key]
    public long gg_game_id { get; set; }

    [Key]
    public int gg_partner_id { get; set; }

    [StringLength(50)]
    public string? gg_name { get; set; }

    [StringLength(50)]
    public string? gg_name_translated { get; set; }

    [StringLength(200)]
    public string? gg_logo { get; set; }

    public bool gg_show_lcd_message { get; set; }

    [Column(TypeName = "money")]
    public decimal gg_played { get; set; }

    [Column(TypeName = "money")]
    public decimal gg_won { get; set; }

    [Column(TypeName = "money")]
    public decimal gg_won_jackpot { get; set; }

    public long gg_num_bets { get; set; }

    public long gg_num_prizes { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime gg_created { get; set; }

    public byte[] gg_last_updated { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal gg_pending { get; set; }

    public int gg_num_pending { get; set; }
}
