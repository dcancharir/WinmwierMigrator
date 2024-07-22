using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("ggi_game_instance_id", "ggi_partner_id")]
public partial class gamegateway_game_instance
{
    [Key]
    public long ggi_game_instance_id { get; set; }

    [Key]
    public int ggi_partner_id { get; set; }

    public long ggi_game_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? ggi_first_prize { get; set; }

    [Column(TypeName = "money")]
    public decimal? ggi_entry_cost { get; set; }

    [Column(TypeName = "money")]
    public decimal? ggi_jackpot { get; set; }

    [Column(TypeName = "money")]
    public decimal ggi_played { get; set; }

    [Column(TypeName = "money")]
    public decimal ggi_won { get; set; }

    [Column(TypeName = "money")]
    public decimal ggi_won_jackpot { get; set; }

    public int ggi_num_bets { get; set; }

    public int ggi_num_prizes { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ggi_created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ggi_starts { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ggi_finished { get; set; }

    public byte[] ggi_last_updated { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal ggi_pending { get; set; }

    public int ggi_num_pending { get; set; }

    public int? ggi_num_bets_rollback { get; set; }
}
