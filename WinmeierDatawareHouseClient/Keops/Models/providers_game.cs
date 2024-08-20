using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

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

    [Column(TypeName = "money")]
    public decimal? pg_payout_11 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_12 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_13 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_14 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_15 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_16 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_17 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_18 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_19 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_20 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_21 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_22 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_23 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_24 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_25 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_26 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_27 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_28 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_29 { get; set; }

    [Column(TypeName = "money")]
    public decimal? pg_payout_30 { get; set; }
}
