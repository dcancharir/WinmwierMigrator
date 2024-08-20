using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("bgsl_site_id", "bgsl_bonusing_session_id")]
public partial class bonusing_games_session
{
    [Key]
    public int bgsl_site_id { get; set; }

    [Key]
    public long bgsl_bonusing_session_id { get; set; }

    public long bgsl_bonusing_id { get; set; }

    public int bgsl_item_id { get; set; }

    public long bgsl_account_id { get; set; }

    public int? bgsl_terminal { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime bgsl_datetime { get; set; }

    [StringLength(500)]
    public string bgsl_combination_bet { get; set; } = null!;

    [StringLength(500)]
    public string bgsl_combination_won { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? bgsl_bet_points { get; set; }

    [Column(TypeName = "money")]
    public decimal? bgsl_won_points { get; set; }

    [Column(TypeName = "money")]
    public decimal? bgsl_bet_redeemable { get; set; }

    [Column(TypeName = "money")]
    public decimal? bgsl_won_redeemable { get; set; }

    [Column(TypeName = "money")]
    public decimal? bgsl_bet_promo_redeemable { get; set; }

    [Column(TypeName = "money")]
    public decimal? bgsl_won_promo_redeemable { get; set; }

    [Column(TypeName = "money")]
    public decimal? bgsl_bet_promo_non_redeemable { get; set; }

    [Column(TypeName = "money")]
    public decimal? bgsl_won_promo_non_redeemable { get; set; }

    public long BGSL_PLAY_SESSION_ID { get; set; }
}
