using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("pg_pv_id", "pg_game_id")]
[Index("pg_game_id", Name = "IX_pg_game_id")]
public partial class providers_game
{
    [Key]
    public int pg_pv_id { get; set; }

    [Key]
    public int pg_game_id { get; set; }

    [StringLength(50)]
    public string pg_game_name { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? pg_payout_1 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_2 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_3 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_4 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_5 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_6 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_7 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_8 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_9 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_10 { get; set; }

    public long? pg_ms_sequence_id { get; set; }
}
