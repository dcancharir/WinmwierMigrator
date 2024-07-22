using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Keyless]
[Table("PROVIDERS_GAMES_FINALLY")]
public partial class PROVIDERS_GAMES_FINALLY
{
    public int? PG_PV_ID { get; set; }

    public int PG_GAME_ID { get; set; }

    [StringLength(50)]
    public string? PG_GAME_NAME { get; set; }

    [Column(TypeName = "money")]
    public decimal? PG_PAYOUT_1 { get; set; }

    [Column(TypeName = "money")]
    public decimal? PG_PAYOUT_2 { get; set; }

    [Column(TypeName = "money")]
    public decimal? PG_PAYOUT_3 { get; set; }

    [Column(TypeName = "money")]
    public decimal? PG_PAYOUT_4 { get; set; }

    [Column(TypeName = "money")]
    public decimal? PG_PAYOUT_5 { get; set; }

    [Column(TypeName = "money")]
    public decimal? PG_PAYOUT_6 { get; set; }

    [Column(TypeName = "money")]
    public decimal? PG_PAYOUT_7 { get; set; }

    [Column(TypeName = "money")]
    public decimal? PG_PAYOUT_8 { get; set; }

    [Column(TypeName = "money")]
    public decimal? PG_PAYOUT_9 { get; set; }

    [Column(TypeName = "money")]
    public decimal? PG_PAYOUT_10 { get; set; }

    [StringLength(50)]
    public string? PG_GAME_TARGET { get; set; }

    public int? PG_PV_ID_NEW { get; set; }

    public int? PG_GAME_ID_NEW { get; set; }
}
